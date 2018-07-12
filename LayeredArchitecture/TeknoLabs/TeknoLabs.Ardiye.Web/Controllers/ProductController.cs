using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknoLabs.Ardiye.Business.Abstract;
using TeknoLabs.Ardiye.Web.Models;

namespace TeknoLabs.Ardiye.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };
            return View(model);
        }
    }
}
