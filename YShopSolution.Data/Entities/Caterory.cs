using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YShopSolution.Data.Entities
{
    public class Caterory
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Image { set; get; }
        public string Description { set; get; }
        public List<Item> Items { get; set; }
    }
}
