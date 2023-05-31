using BenMabelProject.Data.UnitOfWorks;
using BenMabelProject.Entity.DtoS.Order;
using BenMabelProject.Entity.DtoS.Orders;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Services.Extensions;
using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace BenMabelProject.Services.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _User;
        public OrderService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;
            _User = httpContextAccessor.HttpContext.User;
        }

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Kullanıcının Geçmiş siparişlerini Listeleme işlemini gerçekleştirir.
        /// </summary>
        public async Task<OrderDto> ShowOrder()
        {
            OrderDto orderDto = new OrderDto();
            var userId = _User.GetLoggedInUserId();
            var _person = await unitOfWork.GetRepository<Person>().GetAsync(x => x.IdentityId == userId);
            orderDto.person = await unitOfWork.GetRepository<Person>().GetAsync(x => x.IdentityId == userId);
            orderDto.adress = await unitOfWork.GetRepository<PersonAdress>().GetAsync(b => b.PersonId == _person.Id);
            orderDto.phone = await unitOfWork.GetRepository<PersonIphone>().GetAsync(b => b.PersonId == _person.Id);
            orderDto.email = await unitOfWork.GetRepository<PersonEmail>().GetAsync(b => b.PersonId == _person.Id);
            orderDto.basket = await unitOfWork.GetRepository<Basket>().GetAsync(x => x.PersonId == _person.Id);
            var basket = await unitOfWork.GetRepository<Basket>().GetAsync(x => x.PersonId == _person.Id);
            orderDto.basketDetails = await unitOfWork.GetRepository<BasketDetail>().GetAllAsync(x => x.BasketId == basket.Id);
            return orderDto;
        } // Kullanıcı İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Kullanıcının Sipariş Verme işlemini gerçekleştirir.
        /// </summary>
        public async Task AddOrder()
        {
            var userId = _User.GetLoggedInUserId();
            var person = await unitOfWork.GetRepository<Person>().GetAsync(b => b.IdentityId == userId);
            var basket = await unitOfWork.GetRepository<Basket>().GetAsync(b => b.PersonId == person.Id);
            var basketDetail = await unitOfWork.GetRepository<BasketDetail>().GetAllAsync(b => b.BasketId == basket.Id);
            Order order = new();
            order.PersonId = person.Id;
            order.Stuation = 0;
            await unitOfWork.GetRepository<Order>().AddAsync(order);
            await unitOfWork.SaveAsync();
            decimal Total = 0;
            foreach (var item in basketDetail)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderId = order.Id;
                orderDetail.ProductId = item.ProductId;
                orderDetail.Piece = item.Piece;
                orderDetail.Price = item.Price;
                orderDetail.KDV = item.KDV;
                decimal X = ((item.Price * Convert.ToDecimal(item.KDV)) + item.Price) * Convert.ToDecimal(orderDetail.Piece);
                orderDetail.TotalPrice = X;
                Total = X + Total;
                await unitOfWork.GetRepository<OrderDetail>().AddAsync(orderDetail);
                await unitOfWork.SaveAsync();

            }
            foreach (var item in basketDetail)
            {
                await unitOfWork.GetRepository<BasketDetail>().DeleteAsync(item);
                await unitOfWork.SaveAsync();
            }
            OrderPrice orderPrice = new OrderPrice();
            orderPrice.OrderId = order.Id;
            orderPrice.TotalPrice = Total;
            await unitOfWork.GetRepository<OrderPrice>().AddAsync(orderPrice);
            await unitOfWork.SaveAsync();
            OrderSituation orderSituation = new OrderSituation();
            orderSituation.OrderId = order.Id;
            orderSituation.Situation = 0;
            orderSituation.OrderDate = DateTime.Now;
            await unitOfWork.GetRepository<OrderSituation>().AddAsync(orderSituation);
            await unitOfWork.SaveAsync();
        }// Kullanıcı İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Siparişlerin Satatu Durumana Göre Listeleme işlemini gerçekleştirir.
        /// Statu = Onay Bekleyen - Hazırlanmayı Bekleyen - Kargolanmayı Bekleyen - Teslim Edilmeyi Bekleyen
        /// </summary>
        public async Task<List<Order>> ShowOrderForAdmin(int statu)
        {
            var orders = await unitOfWork.GetRepository<Order>().GetAllAsync(b => b.Stuation == statu, b => b.OrderPrice, b => b.OrderSituation, b => b.OrderDetail);
            return orders;
        }  // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde seçilen Siparişin Statüsünü Değirtirme işlemini gerçekleştirir.
        /// Statu = Onay Bekleyen - Hazırlanmayı Bekleyen - Kargolanmayı Bekleyen - Teslim Edilmeyi Bekleyen
        /// </summary>
        public async Task OrderOk(int Id)
        {
            var order = await unitOfWork.GetRepository<Order>().GetAsync(b => b.Id == Id, b => b.OrderSituation);
            var orderStuation = await unitOfWork.GetRepository<OrderSituation>().GetAsync(b => b.OrderId == Id);

            if (order.Stuation == 0)
            {
                orderStuation.ApprovalDate = DateTime.Now;
            }
            else if (order.Stuation == 1)
            {
                orderStuation.PreparationDate = DateTime.Now;
                orderStuation.ShippingDate = DateTime.Now;
            }
            else if (order.Stuation == 2)
            {
                orderStuation.DeliveredDate = DateTime.Now;
            }

            order.Stuation += 1;
            orderStuation.Situation += 1;
            await unitOfWork.GetRepository<Order>().UpdateAsync(order);
            await unitOfWork.GetRepository<OrderSituation>().UpdateAsync(orderStuation);
            await unitOfWork.SaveAsync();
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde seçilen Siparişin Detay Bilgilerini Listeleme işlemini gerçekleştirir.
        /// </summary>
        public async Task<OrderDetailDto> ShowOrderDetail(int Id)
        {
            var order = await unitOfWork.GetRepository<Order>().GetAsync(b => b.Id == Id, b => b.OrderSituation);
            var person = await unitOfWork.GetRepository<Person>().GetAsync(b => b.Id == order.PersonId, b => b.PersonUser);
            var personadres = await unitOfWork.GetRepository<PersonAdress>().GetAllAsync(b => b.PersonId == person.Id);
            var personEmail = await unitOfWork.GetRepository<PersonEmail>().GetAllAsync(b => b.PersonId == person.Id);
            var personIphone = await unitOfWork.GetRepository<PersonIphone>().GetAllAsync(b => b.PersonId == person.Id);
            var detail = await unitOfWork.GetRepository<OrderDetail>().GetAllAsync(b => b.OrderId == Id, b => b.Product);
            OrderDetailDto orderDetail = new OrderDetailDto();
            orderDetail.order = order;
            orderDetail.person = person;
            orderDetail.email = personEmail;
            orderDetail.phone = personIphone;
            orderDetail.adress = personadres;
            orderDetail.orderDetails = detail;
            return orderDetail;
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde seçilen Siparişin Detay Bilgilerini Listeleme işlemini gerçekleştirir.
        /// </summary>
        public async Task<OrderDetailDto> ShowOrderDetailForCustomer(int Id)
        {
            var Identity = _User.GetLoggedInUserId();
            var personControl = await unitOfWork.GetRepository<Person>().GetAsync(b => b.IdentityId == Identity);
            var order = await unitOfWork.GetRepository<Order>().GetAsync(b => b.Id == Id && b.PersonId == personControl.Id, b => b.OrderSituation);
            var person = await unitOfWork.GetRepository<Person>().GetAsync(b => b.Id == order.PersonId, b => b.PersonUser);
            var personadres = await unitOfWork.GetRepository<PersonAdress>().GetAllAsync(b => b.PersonId == person.Id);
            var personEmail = await unitOfWork.GetRepository<PersonEmail>().GetAllAsync(b => b.PersonId == person.Id);
            var personIphone = await unitOfWork.GetRepository<PersonIphone>().GetAllAsync(b => b.PersonId == person.Id);
            var detail = await unitOfWork.GetRepository<OrderDetail>().GetAllAsync(b => b.OrderId == Id, b => b.Product);
            OrderDetailDto orderDetail = new OrderDetailDto();
            orderDetail.order = order;
            orderDetail.person = person;
            orderDetail.email = personEmail;
            orderDetail.phone = personIphone;
            orderDetail.adress = personadres;
            orderDetail.orderDetails = detail;
            return orderDetail;


        } // Kullanıcı İçin
    }
}
