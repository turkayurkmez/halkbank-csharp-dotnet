using eshop.Services;
using eshop.Services.DataTransferObjects.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eshop.MVC.Controllers
{
    [Authorize(Roles = "Admin,Editor")]
    public class ProductsController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }


        public async Task<IActionResult> Index()
        {
            var products = await productService.GetProductsAsync();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            ViewBag.Categories = await GetCategories();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductRequest createProductRequest)
        {
            if (ModelState.IsValid)
            {
                await productService.CreateAsync(createProductRequest);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = await GetCategories();
            return View();

        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await productService.GetProductAsync(id);

            //Dostlar; üşendiğim için ProductDisplayResponse olarak alıp; 
            //UpdateProductRequest instance'ina dönüştürdük.
            //Fakat, ProductDisplayResponse içinde stok değeri olmadığı için onu uydurduk :(
            var updateRequest = new UpdateProductRequest()
            {
                CategoryId = product.CategoryId,
                Description = product.Description,
                Id = product.Id,
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Price = product.Price,
                Stock = 150
            };

            ViewBag.Categories = await GetCategories();
            return View(updateRequest);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProductRequest updateProductRequest)
        {
            if (ModelState.IsValid)
            {
                await productService.UpdateAsync(updateProductRequest);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }



        private async Task<IEnumerable<SelectListItem>> GetCategories()
        {
            var categories = await categoryService.GetCategories();
            var response = categories.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name });
            return response;
        }
    }


}
