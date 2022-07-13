using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keywork { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
