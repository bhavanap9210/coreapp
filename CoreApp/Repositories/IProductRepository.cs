using CoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories
{
    public interface IProductRepository
    {
        ProductsModel[] GetProducts();
    }
}
