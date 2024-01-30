using DILifeTime.Models;
using DILifeTime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DILifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonGuid singleton;
        private readonly ITransientGuid transient;
        private readonly IScopedGuid scoped;
        private readonly GuidService guidService;

        public HomeController(ILogger<HomeController> logger, ISingletonGuid singleton, ITransientGuid transient, IScopedGuid scoped, GuidService guidService)
        {
            _logger = logger;
            this.singleton = singleton;
            this.transient = transient;
            this.scoped = scoped;
            this.guidService = guidService;
        }

        public IActionResult Index()
        {
            ViewBag.SingletonValue = singleton.Guid.ToString();
            ViewBag.TransientValue = transient.Guid.ToString();
            ViewBag.ScopedValue = scoped.Guid.ToString();

            ViewBag.SingletonScope = guidService.SingletonGuid.Guid.ToString();
            ViewBag.TransientScope = guidService.TransientGuid.Guid.ToString();
            ViewBag.ScopedScope = guidService.ScopedGuid.Guid.ToString();



            return View();
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