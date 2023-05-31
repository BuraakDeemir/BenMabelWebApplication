using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.ViewComponents
{
    public class HomeMiniMenuViewComponent : ViewComponent
    {
        private readonly ICategoryService service;

        public HomeMiniMenuViewComponent(ICategoryService service)
        {
            this.service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await service.GetAllCategories();
            return View(categories);
        }
    }
}
