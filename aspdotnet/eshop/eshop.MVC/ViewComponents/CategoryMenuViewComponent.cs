using eshop.Services;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {

        private readonly ICategoryService categoryService;

        public CategoryMenuViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await categoryService.GetCategories();

            return View(categories);
        }
    }
}
