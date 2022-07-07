using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopsolution.Application.Catalog.Products.Dtos;
using eShopsolution.Application.Catalog.Products.Dtos.Public;
using eShopsolution.Application.Dtos;

namespace eShopsolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategory(GetProductPagingRequest request);
    }
}
