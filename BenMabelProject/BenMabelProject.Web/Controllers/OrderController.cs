using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BenMabelProject.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService service;
        private readonly IToastNotification toast;

        public OrderController(IOrderService service,IToastNotification toast)
        {
            this.service = service;
            this.toast = toast;
        }
        public async Task<IActionResult> Index()
        {
            var orderOk = await service.ShowOrder();
            return View(orderOk);
        }
        public async Task<IActionResult> AddOrder()
        {
            await service.AddOrder();
            toast.AddSuccessToastMessage("Siparişin Alınmıştır.");
            return RedirectToAction("Index","Profile");
        }
        public async Task<IActionResult> OrderDetail(int Id)
        {
            var detail = await service.ShowOrderDetailForCustomer(Id);
            return View(detail);
        }
    }
}
