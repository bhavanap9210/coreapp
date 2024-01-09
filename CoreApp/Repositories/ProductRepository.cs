using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models;

namespace CoreApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductsModel[] GetProducts()
        {
            ProductsModel p1 = new ProductsModel() { Id = 1, ProductName = "P1", Price = 100, ManufacturingDate = new DateTime(2019, 1, 1) };
            ProductsModel p2 = new ProductsModel() { Id = 2, ProductName = "P2", Price = 200, ManufacturingDate = new DateTime(2019, 1, 2) };
            ProductsModel p3 = new ProductsModel() { Id = 3, ProductName = "P3", Price = 210, ManufacturingDate = new DateTime(2019, 1, 3) };
            ProductsModel p4 = new ProductsModel() { Id = 4, ProductName = "P4", Price = 220, ManufacturingDate = new DateTime(2019, 1, 4) };
            ProductsModel p5 = new ProductsModel() { Id = 5, ProductName = "P5", Price = 230, ManufacturingDate = new DateTime(2019, 1, 5) };
            ProductsModel p6 = new ProductsModel() { Id = 6, ProductName = "P6", Price = 240, ManufacturingDate = new DateTime(2019, 1, 6) };
            ProductsModel p7 = new ProductsModel() { Id = 7, ProductName = "P7", Price = 250, ManufacturingDate = new DateTime(2019, 1, 7) };
            ProductsModel p11 = new ProductsModel() { Id = 11, ProductName = "P11", Price = 1100, ManufacturingDate = new DateTime(2019, 1, 11) };
            ProductsModel p12 = new ProductsModel() { Id = 12, ProductName = "P12", Price = 1200, ManufacturingDate = new DateTime(2019, 1, 12) };
            ProductsModel p13 = new ProductsModel() { Id = 13, ProductName = "P13", Price = 1210, ManufacturingDate = new DateTime(2019, 1, 13) };
            ProductsModel p14 = new ProductsModel() { Id = 14, ProductName = "P14", Price = 1220, ManufacturingDate = new DateTime(2019, 1, 14) };
            ProductsModel p15 = new ProductsModel() { Id = 15, ProductName = "P15", Price = 1230, ManufacturingDate = new DateTime(2019, 1, 15) };
            ProductsModel p16 = new ProductsModel() { Id = 16, ProductName = "P16", Price = 1240, ManufacturingDate = new DateTime(2019, 1, 16) };
            ProductsModel p17 = new ProductsModel() { Id = 17, ProductName = "P17", Price = 1250, ManufacturingDate = new DateTime(2019, 1, 17) };
            ProductsModel p21 = new ProductsModel() { Id = 21, ProductName = "P21", Price = 2100, ManufacturingDate = new DateTime(2019, 1, 21) };
            ProductsModel p22 = new ProductsModel() { Id = 22, ProductName = "P22", Price = 2200, ManufacturingDate = new DateTime(2019, 1, 22) };
            ProductsModel p23 = new ProductsModel() { Id = 23, ProductName = "P23", Price = 2210, ManufacturingDate = new DateTime(2019, 1, 23) };
            ProductsModel p24 = new ProductsModel() { Id = 24, ProductName = "P24", Price = 2220, ManufacturingDate = new DateTime(2019, 1, 24) };
            ProductsModel p25 = new ProductsModel() { Id = 25, ProductName = "P25", Price = 2230, ManufacturingDate = new DateTime(2019, 1, 25) };
            ProductsModel p26 = new ProductsModel() { Id = 26, ProductName = "P26", Price = 2240, ManufacturingDate = new DateTime(2019, 1, 26) };
            ProductsModel p27 = new ProductsModel() { Id = 27, ProductName = "P27", Price = 2250, ManufacturingDate = new DateTime(2019, 1, 27) };
            ProductsModel p31 = new ProductsModel() { Id = 31, ProductName = "P31", Price = 3100, ManufacturingDate = new DateTime(2019, 1, 11) };
            ProductsModel p32 = new ProductsModel() { Id = 32, ProductName = "P32", Price = 3200, ManufacturingDate = new DateTime(2019, 1, 12) };
            ProductsModel p33 = new ProductsModel() { Id = 33, ProductName = "P33", Price = 3210, ManufacturingDate = new DateTime(2019, 1, 13) };
            ProductsModel p34 = new ProductsModel() { Id = 34, ProductName = "P34", Price = 3220, ManufacturingDate = new DateTime(2019, 1, 14) };
            ProductsModel p35 = new ProductsModel() { Id = 35, ProductName = "P35", Price = 3230, ManufacturingDate = new DateTime(2019, 1, 15) };
            ProductsModel p36 = new ProductsModel() { Id = 36, ProductName = "P36", Price = 3240, ManufacturingDate = new DateTime(2019, 1, 16) };
            ProductsModel p37 = new ProductsModel() { Id = 37, ProductName = "P37", Price = 3250, ManufacturingDate = new DateTime(2019, 1, 17) };
            //return new ProductsModel[] { p1, p2, p3, p4, p5, p6, p7, p11, p12, p13, p14, p15, p16, p17, p21, p22, p23, p24, p25, p26, p27, p31, p32, p33, p34, p35, p36, p37, null };
            return new ProductsModel[] { p1, p2, p3, p4, p5, p6, p7, p11, p12, p13, p14, p15, p16, p17, p21, p22, p23, p24, p25, p26, p27, p31, p32, p33, p34, p35, p36, p37 };
        }
    }
}
