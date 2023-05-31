using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
