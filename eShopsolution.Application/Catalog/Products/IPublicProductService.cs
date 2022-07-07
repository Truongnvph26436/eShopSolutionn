using System;
using System.Collections.Generic;
using System.Text;
using eShopsolution.Application.Catalog.Products.Dtos;
using eShopsolution.Application.Dtos;

namespace eShopsolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageViewModel<ProductViewModel> GetAllByCategory(int categoryId, int pageIndex, int pageSize);
    }
}
