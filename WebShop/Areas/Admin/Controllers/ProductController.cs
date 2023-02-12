using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShop.Core.Contracts;
using WebShop.Core.Models.Products;
using WebShop.Models;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        public async Task<IActionResult> All()
        {
            var model = await productService.AllProducts();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductModel()
            {
                SubCategoies = await productService.GetSubCategories(),
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Add(ProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await productService.AddNewProduct(model);

            return RedirectToAction();
        }
    }
}
