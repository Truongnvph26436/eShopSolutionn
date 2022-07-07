using System;
using System.Collections.Generic;
using System.Text;

namespace eShopsolution.Application.Dtos
{
    public class PageViewModel<T>
    {
        private List<T> Items { set; get; }
        public int TotalRecord { get; set; }
    }
}
