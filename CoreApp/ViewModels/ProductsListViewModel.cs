using CoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<ProductsModel> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
