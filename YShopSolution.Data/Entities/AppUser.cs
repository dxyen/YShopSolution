using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YShopSolution.Data.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public DateTime DoB { get; set; }
    
        public List<Order> Orders { get; set; }

        public List<Cart> Carts { get; set; }

        public AppRole Role { get; set; }
    }
}
