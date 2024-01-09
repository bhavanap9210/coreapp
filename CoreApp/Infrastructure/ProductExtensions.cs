using CoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Infrastructure
{
    public static class ProductExtensions
    {
        /// <summary>
        /// Not using lambda expressions
        /// </summary>
        /// <param name="productsModels"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IEnumerable<ProductsModel> FilterByName(this IEnumerable<ProductsModel> productsModels, string name)
        {
            foreach (var item in productsModels)
            {
                if (item?.ProductName == name)
                    yield return item;
            }
        }


        /// <summary>
        /// Using lambda expression
        /// </summary>
        /// <param name="productsModels"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static IEnumerable<ProductsModel> Filter(this IEnumerable<ProductsModel> productsModels, Func<ProductsModel, bool> selector)
        {
            foreach (var item in productsModels)
            {
                if (selector(item))
                    yield return item;
            }
        }
    }
}
