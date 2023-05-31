using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NotFoundPage()
        {
            return View();
        }
    }
}