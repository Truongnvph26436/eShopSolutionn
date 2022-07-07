using System;
using System.Collections.Generic;
using System.Text;
using eShopsolution.Application.Dtos;

namespace eShopsolution.Application.Catalog.Products.Dtos.Manager
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keywork { get; set; }
        public List<int> CategoryIds { get; set; }

    }
}
