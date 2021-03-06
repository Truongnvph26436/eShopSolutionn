using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace eShopSolution.ViewModels.Catalog.ProductImages
{
    public class ProductImageUpdateRequest
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public int SortOrder { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
