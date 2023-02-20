using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShop.Core.Contracts;
using WebShop.Core.Models.Categories;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryModel model)
        {
            await categoryService.AddNewCategory(model);

            return View();
        }

        public async Task<IActionResult> All()
        {
            var model = await categoryService.GetAllCategory();

            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var category = await categoryService.GetCategoryModelById(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, CategoryModel model)
        {
            await categoryService.EditCategory(id, model);

            return RedirectToAction(nameof(All));
        }

    }
}
