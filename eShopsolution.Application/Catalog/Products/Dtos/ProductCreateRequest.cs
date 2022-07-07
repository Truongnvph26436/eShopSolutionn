using System;
using System.Collections.Generic;
using System.Text;

namespace eShopsolution.Application.Catalog.Products.Dtos
{
    public class ProductCreateRequest
    {
        public string name { get; set; }
        public decimal Price { get; set; }
    }
}
