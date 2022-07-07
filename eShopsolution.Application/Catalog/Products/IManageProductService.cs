using System.Threading.Tasks;
using eShopsolution.Application.Catalog.Products.Dtos;
using eShopsolution.Application.Catalog.Products.Dtos.Manager;
using eShopsolution.Application.Dtos;

namespace eShopsolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);    

        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
