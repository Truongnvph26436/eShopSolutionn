using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopsolution.Application.Catalog.Products.Dtos;
using eShopsolution.Application.Dtos;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;

namespace eShopsolution.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly EShopDbContext _context;
        public ManageProductService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
            };
            _context.Products.Add(product);
           return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PageViewModel<ProductViewModel>> GetAllPaging(string keywork, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
