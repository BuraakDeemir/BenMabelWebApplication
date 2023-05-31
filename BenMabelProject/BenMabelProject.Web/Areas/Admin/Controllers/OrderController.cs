using BenMabelProject.Entity.DtoS.Products;
using BenMabelProject.Services.Services.Abstractions;
using BenMabelProject.Web.Messages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BenMabelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService service;
        private readonly IToastNotification toast;

        public OrderController(IOrderService service,IToastNotification toast)
        {
            this.service = service;
            this.toast = toast;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> NewOrder()
        {
            var orders = await service.ShowOrderForAdmin(0);
            return View(orders);
        }
        public async Task<IActionResult> NewOrderOK(int Id)
        {
            await service.OrderOk(Id);
            toast.AddSuccessToastMessage("Sipariş Onaylandı!", new ToastrOptions { Title = "Bravo!!", });
            return RedirectToAction("NewOrder","Order");
        }
        public async Task<IActionResult> PreparationStage()
        {
            var orders = await service.ShowOrderForAdmin(1);
            return View(orders);
        }
        public async Task<IActionResult> PreparationStageOk(int Id)
        {
            await service.OrderOk(Id);
            toast.AddSuccessToastMessage("Sipariş Kargolandı!", new ToastrOptions { Title = "Bravo!!", });
            return RedirectToAction("PreparationStage", "Order");
        }
        public async Task<IActionResult> CargoStage()
        {
            var orders = await service.ShowOrderForAdmin(2);
            return View(orders);
        }
        public async Task<IActionResult> CargoStageOk(int Id)
        {
            await service.OrderOk(Id);
            toast.AddSuccessToastMessage("Sipariş Teslim Edildi!", new ToastrOptions { Title = "Bravo!!", });
            return RedirectToAction("CargoStage", "Order");
        }
        public async Task<IActionResult> Deliveried()
        {
            var orders = await service.ShowOrderForAdmin(3);
            return View(orders);
        }
        public async Task<IActionResult> OrderDetail(int Id)
        {
            var detail = await service.ShowOrderDetail(Id);
            return View(detail);
        }
    }
}
