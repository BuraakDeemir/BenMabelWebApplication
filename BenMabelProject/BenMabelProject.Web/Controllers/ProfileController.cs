using BenMabelProject.Data.UnitOfWorks;
using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileService service;

        public ProfileController(IProfileService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var profile = await service.ShowProfile();
            return View(profile);
        }
    }
}
