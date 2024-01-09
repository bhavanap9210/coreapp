using CoreApp.Controllers;
using CoreApp.Infrastructure;
using CoreApp.Models;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
//using System.Web.Mvc;
using Xunit;

namespace XUnitTestProject2
{
    public class HomeControllerTest
    {
        class FakeRepository : IProductRepository
        {
            public ProductsModel[] GetProducts()
            {
                ProductsModel p1 = new ProductsModel() { Id = 11, ProductName = "P11", Price = 1100, ManufacturingDate = new DateTime(2019, 1, 1) };
                ProductsModel p2 = new ProductsModel() { Id = 12, ProductName = "P12", Price = 1200, ManufacturingDate = new DateTime(2019, 1, 2) };
                return new ProductsModel[] { p1, p2, null };
            }
        }

        [Fact]
        public void Index()
        {
            HomeController h =new  HomeController(new FakeRepository());
            //Assert.IsType<ViewResult>(h.FilterProductByName());
            var p = h.FilterProductByName();
            Assert.IsType(typeof(ViewResult), p);
            //foreach (var item in p)
            //{
            //    Assert.True(item.Id == 11);
            //    break;
            //}

        }
    }
}
