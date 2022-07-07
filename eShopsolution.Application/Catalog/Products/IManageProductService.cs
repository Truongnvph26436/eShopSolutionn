using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopsolution.Application.Catalog.Products.Dtos;
using eShopsolution.Application.Dtos;

namespace eShopsolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductEditRequest request);

        Task<int> Delete(int productId);

        Task<List<ProductViewModel>> GetAll();
        Task<PageViewModel<ProductViewModel>> GetAllPaging(string keywork, int pageIndex, int pageSize);
    }
}
