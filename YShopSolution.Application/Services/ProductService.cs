using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YShopSolution.Application.Interfaces;
using YShopSolution.Data.EF;
using YShopSolution.Data.Entities;
using YShopSolution.ViewModels;
using YShopSolution.ViewModels.Common;
using YShopSolution.ViewModels.Request.Product;
using YShopSolution.ViewModels.ViewModels;

namespace YShopSolution.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;
        private readonly YShopDbcontext _context;
        public ProductService(YShopDbcontext context)
        {
            
            _context = context;
          
        }
        public async Task<int> CreateAsync(ProductCreateRequest request)
        {
            var item = new Item()
            {
                Price = request.Price,
                Description = request.Description,
                Name = request.Name,
            };
            _context.Items.Add(item);
            return await _context.SaveChangesAsync();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            //get all
            var result = await _context.Items.Select(item => new ProductViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                }).ToListAsync();

            return result;
        }

        public Task<PagedResult<ProductViewModel>> GetAllPagingAsync(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetBestSellerCakesAsync(int take)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }
    }
}
