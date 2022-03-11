using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YShopSolution.ViewModels.Request.System.Users
{
    public class RegisterRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public DateTime DoB { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
