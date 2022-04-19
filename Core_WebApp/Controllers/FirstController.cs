using Microsoft.AspNetCore.Mvc;

namespace Core_WebApp.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
