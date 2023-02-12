using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShop.Core.Contracts;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService subCategoryService;
        public SubCategoryController(ISubCategoryService _subCategoryService)
        {
            subCategoryService = _subCategoryService;
        }

        public async Task<IActionResult> All(Guid id)
        {
            var model = await subCategoryService.GetAllSubCategory(id);

            return View(model);

        }
    }
}
