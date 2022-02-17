using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YShopSolution.ViewModels;
using YShopSolution.ViewModels.Request.Product;

namespace YShopSolution.Application.Interfaces
{
    public interface IProductService
    {
        Task<int> CreateAsync(ProductCreateRequest request);
        Task<int> UpdateAsync(ProductUpdateRequest request);
        Task<int> DeleteAsync(int id);
        Task<int> GetAsync(int id);

    }
}
