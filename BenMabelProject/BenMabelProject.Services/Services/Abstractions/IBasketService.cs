using BenMabelProject.Entity.DtoS.Basket;
using BenMabelProject.Entity.DtoS.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Services.Services.Abstractions
{
    public interface IBasketService
    {
        Task<bool> AddBasket(ProductDto DetailDto);
        Task<List<BasketDto>> ShowBasket();
        Task DeleteProductFromBasket(int Id);
    }
}
