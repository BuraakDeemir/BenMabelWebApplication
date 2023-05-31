using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
