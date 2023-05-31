using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.ViewComponents
{
    public class FinansMountViewComponent : ViewComponent
    {
        private readonly IFinanceService service;

        public FinansMountViewComponent(IFinanceService service)
        {
            this.service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Report = await service.FinanceMounth();
            return View(Report);
        }
    }
}
