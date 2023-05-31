using BenMabelProject.Entity.DtoS.Order;
using BenMabelProject.Entity.DtoS.Orders;
using BenMabelProject.Entity.Entities;

namespace BenMabelProject.Services.Services.Abstractions
{
    public interface IOrderService
    {
        Task<OrderDto> ShowOrder();
        Task AddOrder();
        Task<List<Order>> ShowOrderForAdmin(int statu);
        Task OrderOk(int Id);
        Task<OrderDetailDto> ShowOrderDetail(int Id);
        Task<OrderDetailDto> ShowOrderDetailForCustomer(int Id);
    }
}
