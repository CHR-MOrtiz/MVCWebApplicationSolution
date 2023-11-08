using Microsoft.AspNetCore.Mvc;
using MVCWebApplication.Models;

namespace MVCWebApplication.Controllers
{
    public class Bootstrap5Controller : Controller
    {
        public IActionResult Index()
        {
            var model = new Bootstrap5ViewModel { Id = 1 };
            return View(model);
        }
    }
}
