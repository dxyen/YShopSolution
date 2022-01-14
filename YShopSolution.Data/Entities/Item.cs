using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YShopSolution.Data.Entities
{
    public class Item
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
