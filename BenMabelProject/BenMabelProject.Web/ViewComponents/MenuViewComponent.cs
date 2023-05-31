using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly ICategoryService service;

        public MenuViewComponent(ICategoryService service)
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
