using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class ShoppingCartModel : IEnumerable<ProductsModel>
    {
        public IEnumerable<ProductsModel> Products { get; set; }
        public IEnumerator<ProductsModel> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
