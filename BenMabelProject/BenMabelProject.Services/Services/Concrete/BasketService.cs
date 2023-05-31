using AutoMapper;
using BenMabelProject.Data.UnitOfWorks;
using BenMabelProject.Entity.DtoS.Basket;
using BenMabelProject.Entity.DtoS.Products;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Services.Extensions;
using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;


namespace BenMabelProject.Services.Services.Concrete
{
    public class BasketService : IBasketService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly ClaimsPrincipal _User;
        public BasketService(IHttpContextAccessor httpContextAccessor,IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            _User = httpContextAccessor.HttpContext.User;
        }
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Seçilen Ürünü Sepete Ekleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<bool> AddBasket(ProductDto DetailDto)
        {
            var result = false;
            string Email = _User.GetLoggedInEmail();
            if (Email != null)
            {
                var userId = _User.GetLoggedInUserId();
                var person = await unitOfWork.GetRepository<Person>().GetAsync(x => x.IdentityId == userId);
                var basketControl = await unitOfWork.GetRepository<Basket>().GetAsync(x => x.PersonId == person.Id);
                if (basketControl == null)
                {
                    Basket basket = new Basket();
                    basket.PersonId = person.Id;
                    await unitOfWork.GetRepository<Basket>().AddAsync(basket);
                    await unitOfWork.SaveAsync();
                    var product = await unitOfWork.GetRepository<Product>().GetAsync(x => x.Id == DetailDto.Id);
                    var _price = await unitOfWork.GetRepository<ProductPrice>().GetAsync(x => x.ProductId == DetailDto.Id);
                    BasketDetail detail = new BasketDetail();
                    detail.BasketId = basket.Id;
                    detail.ProductId = product.Id;
                    detail.Piece = DetailDto.Adet;
                    detail.Price = _price.Price;
                    detail.KDV= _price.KDV;
                    detail.ProductName = product.ProductName;
                    detail.TotalPrice =( (_price.Price * Convert.ToDecimal(_price.KDV)) + _price.Price) * DetailDto.Adet;
                    await unitOfWork.GetRepository<BasketDetail>().AddAsync(detail);
                    await unitOfWork.SaveAsync();
                }
                else
                {
                    var product = await unitOfWork.GetRepository<Product>().GetAsync(x=> x.Id == DetailDto.Id);
                    var _price = await unitOfWork.GetRepository<ProductPrice>().GetAsync(x => x.ProductId == product.Id);
                    BasketDetail detail = new BasketDetail();
                    detail.BasketId = basketControl.Id;
                    detail.ProductId = product.Id;
                    detail.Piece = DetailDto.Adet;
                    detail.Price = _price.Price;
                    detail.KDV = _price.KDV;
                    detail.ProductName = product.ProductName;
                    detail.TotalPrice = ((_price.Price * Convert.ToDecimal(_price.KDV)) + _price.Price) * DetailDto.Adet;
                    await unitOfWork.GetRepository<BasketDetail>().AddAsync(detail);
                    await unitOfWork.SaveAsync();
                }
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }  //Kullanıcı İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Sepetteki Ürünleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<BasketDto>> ShowBasket()
        {
            var userId = _User.GetLoggedInUserId();
            var person = await unitOfWork.GetRepository<Person>().GetAsync(x => x.IdentityId == userId);
            var basket = await unitOfWork.GetRepository<Basket>().GetAsync(x => x.PersonId == person.Id);
            if (basket != null)
            {
                List<BasketDetail> result = await unitOfWork.GetRepository<BasketDetail>().GetAllAsync(x => x.BasketId == basket.Id);
                List<BasketDto> map = mapper.Map<List<BasketDto>>(result);
                return map;
            }
            else
            {
                Basket xBasket = new Basket();
                xBasket.PersonId = person.Id;
                await unitOfWork.GetRepository<Basket>().AddAsync(xBasket);
                await unitOfWork.SaveAsync();
                List<BasketDetail> xResult = await unitOfWork.GetRepository<BasketDetail>().GetAllAsync(x => x.BasketId == xBasket.Id);
                List<BasketDto> xMap = mapper.Map<List<BasketDto>>(xResult);
                return xMap;
            }

        }  //Kullanıcı İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Seçili Ürünün Sepetten Çıkarılma İşlemini Gerçekleştirir.
        /// </summary>
        public async Task DeleteProductFromBasket(int Id)
        {
            var product = await unitOfWork.GetRepository<BasketDetail>().GetAsync(x => x.Id == Id);
            await unitOfWork.GetRepository<BasketDetail>().DeleteAsync(product);
            await unitOfWork.SaveAsync();
        }  //Kullanıcı İçin
    }
}
