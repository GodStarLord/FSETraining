using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracCheck.BO;

namespace PracCheck.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AnonymousUserController : ControllerBase
    {
        private readonly MenuOperation _operation;

        public AnonymousUserController(MenuOperation operation)
        {
            _operation = operation;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _operation.GetMenuItems();

            return Ok(result);
        }
    }
}