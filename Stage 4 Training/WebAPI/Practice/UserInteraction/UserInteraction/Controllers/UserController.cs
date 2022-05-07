using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using UserInteraction.DTO;
using UserInteraction.Models;

namespace UserInteraction.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User> users = new List<User>();
        private SymmetricSecurityKey _symmetricKey;

        public UserController(IConfiguration configuration)
        {
            _symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"]));
        }

        public string CreateToken(int userType) //create token
        {
            string role = "";

            if (userType == 1)
                role = "Admin";
            else if (userType == -1)
                role = "Customer";

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Role,role)
            };

            var credential = new SigningCredentials(_symmetricKey, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(3),
                SigningCredentials = credential
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescription);

            return tokenHandler.WriteToken(token);
        }

        [HttpPost("login")]
        public IActionResult Login(UserDTO user)
        {
            var myUser = users.FirstOrDefault(x => x.UserName == user.UserName);
            
            if (myUser == null)
                return Unauthorized("Username does not exist");
            
            using var hmac = new HMACSHA512(myUser.PasswordSalt);
            
            var checkPasswordhash = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
            
            for (int i = 0; i < checkPasswordhash.Length; i++)
            {
                if (checkPasswordhash[i] != myUser.PasswordHash[i])
                    return Unauthorized("Invalid Password");
            }

            var result = new TokenDTO()
            {
                UserName = user.UserName,
                Token = CreateToken(user.UserType),
            };
            
            return Ok(result);
        }

        [HttpPost("register")]
        public IActionResult Register(int id, string userName, string password)
        {
            using (var hmac = new HMACSHA512())
            {
                var user = new User
                {
                    Id = id,
                    UserName = userName,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                    PasswordSalt = hmac.Key
                };

                users.Add(user);
            }
            return Ok("User Registered Successfully");
        }
    }
}