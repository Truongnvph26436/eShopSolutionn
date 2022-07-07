using System;
using System.Collections.Generic;
using System.Text;
using eShopsolution.Application.Dtos;

namespace eShopsolution.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase 
    {
        public int? CategoryId { get; set; }
    }
}
