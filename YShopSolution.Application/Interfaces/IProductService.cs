using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YShopSolution.ViewModels;
using YShopSolution.ViewModels.Common;
using YShopSolution.ViewModels.Request.Product;
using YShopSolution.ViewModels.ViewModels;

namespace YShopSolution.Application.Interfaces
{
    public interface IProductService
    {
        Task<int> CreateAsync(ProductCreateRequest request);
        Task<int> UpdateAsync(ProductUpdateRequest request);
        Task<int> DeleteAsync(int id);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<PagedResult<ProductViewModel>> GetAllPagingAsync(GetProductPagingRequest request);
        Task<List<ProductViewModel>> GetByIdAsync(int productId);
        Task<List<ProductViewModel>> GetBestSellerCakesAsync(int take);

        Task<List<ProductViewModel>> GetAll();

    }
}
