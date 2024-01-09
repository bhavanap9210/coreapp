using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreApp.Models;
using CoreApp.Infrastructure;
using CoreApp.Repositories;
using CoreApp.ViewModels;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace CoreApp.Controllers
{
    public class HomeController : Controller
    {
        IProductRepository _productRepository;
        MetaOptions _metaOptions;

        //strongly typed class
        private readonly IConfiguration _configuration;

        public HomeController(IProductRepository productRepository, IOptions<MetaOptions> authorOptions, IConfiguration configuration)
        {
            _productRepository = productRepository;
            _metaOptions = authorOptions.Value;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            List<string> l = new List<string>();
            foreach (ProductsModel item in ProductsModel.GetProducts())
            {
                int Id = item?.Id ?? -1; //?. conditional operator; ?? coalescing operator
                string name = item?.ProductName ?? "No Name";
                decimal? price = item?.Price ?? 0;
                l.Add($"Id: {Id}, Name: {name}, Price: {price}");
            }
            l.Add($"Id: {0}, Name: {_metaOptions.Author.FirstName}, Price: {0}");
            var settings = _configuration.GetSection("AppSettings").Get<AppSettings>();
            return View(l);
        }
        public int pageSize = 4;
        public IActionResult FilterProductByName()
        {
            IEnumerable<ProductsModel> l = _productRepository.GetProducts().FilterByName("P1");
            return View(l);
        }

        public IActionResult ProductPaging(int pageIndex)
        {
            IEnumerable<ProductsModel> l = _productRepository.GetProducts().Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return View(l);
        }

        public IActionResult ProductCustomPaging(int pageIndex)
        {
            ProductsListViewModel pm = new ProductsListViewModel();
            var ele = _productRepository.GetProducts();
            pm.Products = ele.Skip((pageIndex - 1) * pageSize).Take(pageSize).Where(a=>a!=null);
            pm.PagingInfo = new PagingInfo
            {
                CurrentPage = pageIndex,
                ItemsPerPage = pageSize,
                TotalItems = ele.Count()
            };
            return View(pm);
        }

        public IActionResult FilterProdByName(string name)
        {
            IEnumerable<ProductsModel> l = _productRepository.GetProducts().FilterByName(name);
            return View(l);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
