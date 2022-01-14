using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YShopSolution.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }

        public Item Item { get; set; }
        public int ItemId { get; set; }
        public string Comments { get; set; }
    }
}
