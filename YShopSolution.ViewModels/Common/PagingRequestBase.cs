using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YShopSolution.ViewModels.Common
{
    public class PagingRequestBase
    {
        public int Limit { get; set; }
        public int Page { get; set; }
    }
}
