using GeekShopping.Controllers;
using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _productService.FindAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.Create(product);
                if (response != null)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Update(long id)
        {
            var product = await _productService.FindById(id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.Update(product);
                if (response != null)
                    return RedirectToAction(nameof(Index));
                else
                    return NotFound();
            }

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(long id)
        {
            var product = await _productService.FindById(id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProductModel product)
        {
            var response = await _productService.Delete(product.Id);
            if (response)
                return RedirectToAction(nameof(Index));

            return View(product);
        }
    }
}
