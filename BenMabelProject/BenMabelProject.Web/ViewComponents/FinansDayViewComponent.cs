using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.ViewComponents
{
    public class FinansDayViewComponent : ViewComponent
    {
        private readonly IFinanceService financeService;

        public FinansDayViewComponent(IFinanceService financeService)
        {
            this.financeService = financeService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var finans =await financeService.FinanceDay();
            return View(finans);
        }
    }
}
