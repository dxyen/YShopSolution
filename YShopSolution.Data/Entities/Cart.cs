using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YShopSolution.Data.Entities
{
    public class Cart
    {
        [Key]
        public Guid UserId { get; set; }

        public AppUser User { get; set; }

        [Key]
        public int ItemId { get; set; }

        public Item Item { get; set; }
        public int Amount { get; set; }
    }
}
