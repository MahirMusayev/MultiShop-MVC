using Microsoft.AspNetCore.Mvc;

namespace TaskMVC.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
