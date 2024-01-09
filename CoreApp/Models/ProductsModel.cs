using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Decimal? Price { get; set; }
        [UIHint("DateTime2")]
        public DateTime? ManufacturingDate { get; set; }

        public bool IsStock { get; } = true;

        public static ProductsModel[] GetProducts()
        {
            ProductsModel p1 = new ProductsModel() { Id = 1, ProductName = "P1", Price = 100, ManufacturingDate = new DateTime(2019, 1, 1) };
            ProductsModel p2 = new ProductsModel() { Id = 2, ProductName = "P2", Price = 200, ManufacturingDate = new DateTime(2019, 1, 2) };
            return new ProductsModel[] { p1, p2, null };
        }
    }
}
