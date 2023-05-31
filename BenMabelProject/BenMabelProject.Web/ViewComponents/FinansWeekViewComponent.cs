using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.ViewComponents
{
    public class FinansWeekViewComponent : ViewComponent
    {
        private readonly IFinanceService service;

        public FinansWeekViewComponent(IFinanceService service)
        {
            this.service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Report = await service.FinanceWeek();
            return View(Report);
        }
    }
}
