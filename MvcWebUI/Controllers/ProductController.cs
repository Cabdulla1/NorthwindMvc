using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcWebUI.Models;
using Business.Abstract;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        

        public IActionResult Index(int categoryId)
        {
            var model = new ProductListViewModel()
            {
                Products = categoryId>0 ?  _productService.GetByCategoryId(categoryId) : _productService.GetAllProducts()
            };
            return View(model);
        }
    }
}
