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
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace PracCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;

        public AuthController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [NonAction]
        public string GenerateJSONWebToken(int id)  //The function generates Json web token
        {
            string userRole = "";

            if (id == -1) userRole = "";
            else if (id == 1) userRole = "Admin";
            else userRole = "Customer";

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["TokenKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.NameId, userRole)
            };

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(3),
                SigningCredentials = credentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescription);

            return tokenHandler.WriteToken(token);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var token = GenerateJSONWebToken(id);

            return Ok(token);
        }
    }
}