using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace UserInteraction.DTO
{
    public class UserDTO
    {
        public int UserType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
