using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace FinalCheck.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }
        private string GenerateJSONWebToken(int userId)
        {
            string userRole = "";
            if (userId == 1) userRole = "Admin";
            else if (userId == -1) userRole = "";
            else userRole = "Customer";
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["TokenKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, userRole),
                new Claim("UserId", userId.ToString())
            };


            var token = new JwtSecurityToken(
                issuer: "mySystem",
                audience: "myUsers",
                claims: claims,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }   //Generate Token Function

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            string tokenStr = GenerateJSONWebToken(id);  //Generate Token
            return new OkObjectResult(new { token = tokenStr });
        }
    }
}