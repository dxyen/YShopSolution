using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YShopSolution.ViewModels.Common;

namespace YShopSolution.ViewModels.Request.Product
{
    public class GetProductPagingRequest : PagingRequestBase
    {
#nullable enable
        public string? Keyword { get; set; }
        public List<int>? CategoryIds { get; set; }
#nullable disable
    }
}
