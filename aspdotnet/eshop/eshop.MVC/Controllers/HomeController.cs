using eshop.Entities;
using eshop.MVC.Models;
using eshop.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }



        public async Task<IActionResult> Index(int? catid = null, int page = 1)
        {
            var products = catid is null ? await productService.GetProductsAsync() :
                                           await productService.GetProductsByCategoryIdAsync(catid.Value);



            var totalItemCount = products.Count();
            var itemsPerPage = 4;
            var totalPages = (int)Math.Ceiling((decimal)totalItemCount / itemsPerPage);

            /*
             *   1. sayfa: 0 atla 4 al
             *   2. sayfa: 4 atla 4 al
             *   3. sayfa: 8 atla 4 al
             *   
             *   
             *   
             */
            var paginatedProducts = products.OrderBy(p => p.Id)
                                            .Skip((page - 1) * itemsPerPage)
                                            .Take(itemsPerPage);




            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.CategoryId = catid;


            return View(paginatedProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}