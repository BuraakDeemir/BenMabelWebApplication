using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.ViewComponents
{
    public class HomeProductsViewComponent : ViewComponent
    {
        private readonly IProductService service;

        public HomeProductsViewComponent(IProductService service)
        {
            this.service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await service.GetAllProduct();
            return View(products);
        }
    }
}
