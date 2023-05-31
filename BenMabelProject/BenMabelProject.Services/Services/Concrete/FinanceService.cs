using BenMabelProject.Data.UnitOfWorks;
using BenMabelProject.Entity.DtoS.Finanss;
using BenMabelProject.Entity.DtoS.Order;
using BenMabelProject.Entity.DtoS.Orders;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Services.Services.Abstractions;

namespace BenMabelProject.Services.Services.Concrete
{
    public class FinanceService : IFinanceService
    {
        private readonly IUnitOfWork unitOfWork;
        public FinanceService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde İçinde Bulunduğunuz Günün Satış Verilerini Getirme işlemini gerçekleştirir.
        /// </summary>
        public async Task<FinanceDayDto> FinanceDay()
        {
            var orders = await unitOfWork.GetRepository<Order>().GetAllAsync(b=>b.OrderSituation.OrderDate.Day == DateTime.Now.Day,b=>b.OrderSituation,b=>b.OrderPrice);
            var NewOrder = await unitOfWork.GetRepository<Order>().GetAllAsync(b => b.OrderSituation.OrderDate.Day == DateTime.Now.Day && b.Stuation == 0, b => b.OrderSituation, b => b.OrderPrice);
            FinanceDayDto financeDayDto = new FinanceDayDto();
            financeDayDto.NewOrder = NewOrder.Count();
            foreach (var order in orders)
            {
                financeDayDto.TotalPrice += Convert.ToDouble(order.OrderPrice.TotalPrice);
            }
            financeDayDto.TotalOrder= orders.Count();
            return financeDayDto;
        }

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde İçinde Bulunduğunuz Haftanın Satış Verilerini Getirme işlemini gerçekleştirir.
        /// </summary>
        public async Task<FinanceDayDto> FinanceWeek()
        {
            var orders = await unitOfWork.GetRepository<Order>().GetAllAsync(b => b.OrderSituation.OrderDate >= DateTime.Now.AddDays(-7), b => b.OrderSituation, b => b.OrderPrice);
            var NewOrder = await unitOfWork.GetRepository<Order>().GetAllAsync(b => b.OrderSituation.OrderDate >= DateTime.Now.AddDays(-7) && b.Stuation == 0, b => b.OrderSituation, b => b.OrderPrice);
            FinanceDayDto financeDayDto = new FinanceDayDto();
            financeDayDto.NewOrder = NewOrder.Count();
            foreach (var order in orders)
            {
                financeDayDto.TotalPrice += Convert.ToDouble(order.OrderPrice.TotalPrice);
            }
            financeDayDto.TotalOrder = orders.Count();
            return financeDayDto;
        }

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde İçinde Bulunduğunuz Ayın Satış Verilerini Getirme işlemini gerçekleştirir.
        /// </summary>
        public async Task<FinanceDayDto> FinanceMounth()
        {
            var orders = await unitOfWork.GetRepository<Order>().GetAllAsync(b => b.OrderSituation.OrderDate >= DateTime.Now.AddDays(-30), b => b.OrderSituation, b => b.OrderPrice);
            var NewOrder = await unitOfWork.GetRepository<Order>().GetAllAsync(b => b.OrderSituation.OrderDate >= DateTime.Now.AddDays(-30) && b.Stuation == 0, b => b.OrderSituation, b => b.OrderPrice);
            FinanceDayDto financeDayDto = new FinanceDayDto();
            financeDayDto.NewOrder = NewOrder.Count();
            foreach (var order in orders)
            {
                financeDayDto.TotalPrice += Convert.ToDouble(order.OrderPrice.TotalPrice);
            }
            financeDayDto.TotalOrder = orders.Count();
            return financeDayDto;
        }
    

    
    
    }
}
