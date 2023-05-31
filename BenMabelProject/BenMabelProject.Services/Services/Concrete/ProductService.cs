using AutoMapper;
using BenMabelProject.Data.UnitOfWorks;
using BenMabelProject.Entity.DtoS.Products;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Entity.Enums;
using BenMabelProject.Services.Extensions;
using BenMabelProject.Services.Helpers.Images;
using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace BenMabelProject.Services.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.imageHelper = imageHelper;
            _user = httpContextAccessor.HttpContext.User;
        }

        // =========================== Admin Area Başlangıç ===============================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Ürün Ekleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task AddProductAsync(ProductAddDto productAddDto)
        {
            // UserId ve Email Şuan kullanılmamaktadır.
            Guid UserId = _user.GetLoggedInUserId();
            string UserEmail = _user.GetLoggedInEmail();
            var product = new Product
            {
                ProductName = productAddDto.ProductName,
                Stock = productAddDto.Stock,
                CategoryId = productAddDto.CategoryId,
                IsDeleted = productAddDto.IsDeleted
            };
            await unitOfWork.GetRepository<Product>().AddAsync(product);
            await unitOfWork.SaveAsync();
            var productPrice = new ProductPrice
            {
                ProductId = product.Id,
                KDV = productAddDto.ProductPrice.KDV,
                Price = productAddDto.ProductPrice.Price
            };
            var image1 = await imageHelper.Upload((productAddDto.ProductName + "_1"), productAddDto.Img1, ImageType.Post);
            var image2 = await imageHelper.Upload((productAddDto.ProductName + "_2"), productAddDto.Img2, ImageType.Post);
            var image3 = await imageHelper.Upload((productAddDto.ProductName + "_3"), productAddDto.Img3, ImageType.Post);
            var image4 = await imageHelper.Upload((productAddDto.ProductName + "_4"), productAddDto.Img4, ImageType.Post);
            ProductImg productImg = new();
            productImg.ProductId = product.Id;
            productImg.Img_1_FileName = image1.FullName;
            productImg.Img_1_FileType = productAddDto.Img1.ContentType;
            productImg.Img_2_FileName = image2.FullName;
            productImg.Img_2_FileType = productAddDto.Img2.ContentType;
            productImg.Img_3_FileName = image3.FullName;
            productImg.Img_3_FileType = productAddDto.Img3.ContentType;
            productImg.Img_4_FileName = image4.FullName;
            productImg.Img_4_FileType = productAddDto.Img4.ContentType;
            var productDetail = new ProductDetail
            {
                ProductId = product.Id,
                detail = productAddDto.ProductDetail.detail
            };
            await unitOfWork.GetRepository<ProductPrice>().AddAsync(productPrice);
            await unitOfWork.GetRepository<ProductImg>().AddAsync(productImg);
            await unitOfWork.GetRepository<ProductDetail>().AddAsync(productDetail);
            await unitOfWork.SaveAsync();
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Satışta olan ve olmayan tüm Ürünleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<Product>> GetAllProductForAdmin()
        {
            var product = await unitOfWork.GetRepository<Product>().GetAllAsync(x => !x.IsDeleted, x => x.ProductPrice, x => x.Category, x => x.ProductDetail, x => x.ProductImg);
            var productNoSale = await unitOfWork.GetRepository<Product>().GetAllAsync(x => x.IsDeleted, x => x.ProductPrice, x => x.Category, x => x.ProductDetail, x => x.ProductImg);
            List<Product> AllProducts = product.Concat(productNoSale).ToList();
            return AllProducts;
        }  // Admin İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Satışta olan tüm Ürünleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<Product>> GetAllProductForRemove()
        {
            var product = await unitOfWork.GetRepository<Product>().GetAllAsync(x => !x.IsDeleted, x => x.ProductPrice, x => x.Category, x => x.ProductDetail, x => x.ProductImg);
            return product;
        } // Admin İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde seçilen Ürünü Satışdan Kaldırma işlemini gerçekleştirir.
        /// </summary>
        public async Task<string> SafeDeleteProduct(int productId)
        {
            var product = await unitOfWork.GetRepository<Product>().GetByIdAsync(productId);
            product.IsDeleted = true;
            await unitOfWork.GetRepository<Product>().UpdateAsync(product);
            await unitOfWork.SaveAsync();
            return product.ProductName;
        } // Admin İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Satışta olmayan tüm Ürünleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<Product>> GetAllProductForActive()
        {
            var product = await unitOfWork.GetRepository<Product>().GetAllAsync(x => x.IsDeleted, x => x.ProductPrice, x => x.Category, x => x.ProductDetail, x => x.ProductImg);
            return product;
        } // Admin İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Seçilen ürünü tekrar satışa alma İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<string> AgainSaleProduct(int productId)
        {
            var product = await unitOfWork.GetRepository<Product>().GetByIdAsync(productId);
            product.IsDeleted = false;
            await unitOfWork.GetRepository<Product>().UpdateAsync(product);
            await unitOfWork.SaveAsync();
            return product.ProductName;
        } // Admin İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde güncelleme yapmak için seçilen ürünün bilgilerini getirme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<ProductUpdateDto> GetProduct(int productId)
        {
            var product = await unitOfWork.GetRepository<Product>().GetByIdAsync(productId);

            var productDetail = await unitOfWork.GetRepository<ProductDetail>().GetAllAsync();
            foreach (var item in productDetail)
            {
                if (item.ProductId == productId)
                    product.ProductDetail = item;
            }

            var productPrice = await unitOfWork.GetRepository<ProductPrice>().GetAllAsync();
            foreach (var item in productPrice)
            {
                if (item.ProductId == productId)
                    product.ProductPrice = item;
            }

            var ProductImg = await unitOfWork.GetRepository<ProductImg>().GetAllAsync();
            foreach (var item in ProductImg)
            {
                if (item.ProductId == productId)
                    product.ProductImg = item;
            }
            var map = mapper.Map<ProductUpdateDto>(product);
            return map;
        } // Admin İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde seçili ürün için girilen yeni verileri database aktarma İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<string> UpdateProduct(ProductUpdateDto productUpdateDto)
        {
            var product = await unitOfWork.GetRepository<Product>().GetAsync(x => x.Id == productUpdateDto.Id, x => x.ProductPrice, x => x.Category, x => x.ProductDetail, x => x.ProductImg);
            product.ProductName = productUpdateDto.ProductName;
            product.Stock = productUpdateDto.Stock;
            product.CategoryId = productUpdateDto.CategoryId;
            product.IsDeleted = productUpdateDto.IsDeleted;
            await unitOfWork.GetRepository<Product>().UpdateAsync(product);
            var productPrice = await unitOfWork.GetRepository<ProductPrice>().GetAsync(x => x.ProductId == product.Id);
            productPrice.Price = productUpdateDto.ProductPrice.Price;
            productPrice.KDV = productUpdateDto.ProductPrice.KDV;
            await unitOfWork.GetRepository<ProductPrice>().UpdateAsync(productPrice);
            var ProductImg = await unitOfWork.GetRepository<ProductImg>().GetAsync(x => x.ProductId == product.Id);

            if (productUpdateDto.Img1 != null)
            {
                imageHelper.Delete(ProductImg.Img_1_FileName);
                var img1Upload = await imageHelper.Upload(productUpdateDto.ProductName, productUpdateDto.Img1, ImageType.Post);
                ProductImg.Img_1_FileName = img1Upload.FullName;
                ProductImg.Img_1_FileType = productUpdateDto.Img1.ContentType;
            }

            if (productUpdateDto.Img2 != null)
            {
                imageHelper.Delete(ProductImg.Img_2_FileName);
                var img2Upload = await imageHelper.Upload(productUpdateDto.ProductName, productUpdateDto.Img2, ImageType.Post);
                ProductImg.Img_2_FileName = img2Upload.FullName;
                ProductImg.Img_2_FileType = productUpdateDto.Img2.ContentType;
            }

            if (productUpdateDto.Img3 != null)
            {
                imageHelper.Delete(ProductImg.Img_3_FileName);
                var img3Upload = await imageHelper.Upload(productUpdateDto.ProductName, productUpdateDto.Img3, ImageType.Post);
                ProductImg.Img_3_FileName = img3Upload.FullName;
                ProductImg.Img_3_FileType = productUpdateDto.Img3.ContentType;
            }

            if (productUpdateDto.Img4 != null)
            {
                imageHelper.Delete(ProductImg.Img_4_FileName);
                var img4Upload = await imageHelper.Upload(productUpdateDto.ProductName, productUpdateDto.Img4, ImageType.Post);
                ProductImg.Img_4_FileName = img4Upload.FullName;
                ProductImg.Img_4_FileType = productUpdateDto.Img4.ContentType;
            }

            await unitOfWork.GetRepository<ProductImg>().UpdateAsync(ProductImg);
            var ProductDetail = await unitOfWork.GetRepository<ProductDetail>().GetAsync(x => x.ProductId == product.Id);
            ProductDetail.detail = productUpdateDto.ProductDetail.detail;
            await unitOfWork.GetRepository<ProductDetail>().UpdateAsync(ProductDetail);
            await unitOfWork.SaveAsync();
            return product.ProductName;

        } // Admin İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Ürünleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<ProductDto>> GetAllProduct()
        {

            var product = await unitOfWork.GetRepository<Product>().GetAllAsync(x => !x.IsDeleted, x => x.ProductPrice, x => x.Category,x => x.ProductImg);
            var map = mapper.Map<List<ProductDto>>(product);
            return map;
        } // Kullanıcı İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Seçilen Kategorideki Ürünleri Listeleme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<List<ProductDto>> GetCategoryProduct(int CategoryId)
        {

            var product = await unitOfWork.GetRepository<Product>().GetAllAsync(x => !x.IsDeleted && x.CategoryId == CategoryId, x => x.ProductPrice, x => x.Category, x => x.ProductImg);
            var map = mapper.Map<List<ProductDto>>(product);
            return map;
        }  // Kullanıcı İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Seçilen Ürünün Detaylarını Getirme İşlemini Gerçekleştirir.
        /// </summary>
        public async Task<ProductDto> GetProductById(int ProductId)
        {
            var product = await unitOfWork.GetRepository<Product>().GetByIdAsync(ProductId);
            product.Adet = 1;
            var productDetail = await unitOfWork.GetRepository<ProductDetail>().GetAllAsync();
            foreach (var item in productDetail)
            {
                if (item.ProductId == ProductId)
                    product.ProductDetail = item;
            }

            var productPrice = await unitOfWork.GetRepository<ProductPrice>().GetAllAsync();
            foreach (var item in productPrice)
            {
                if (item.ProductId == ProductId)
                    product.ProductPrice = item;
            }

            var ProductImg = await unitOfWork.GetRepository<ProductImg>().GetAllAsync();
            foreach (var item in ProductImg)
            {
                if (item.ProductId == ProductId)
                    product.ProductImg = item;
            }
            var Categories = await unitOfWork.GetRepository<Category>().GetAllAsync();
            foreach (var item in Categories)
            {
                if (item.Id == product.CategoryId)
                    product.Category = item;
            }
            var map = mapper.Map<ProductDto>(product);
            return map;
        } // Kullanıcı İçin
        // ========================== Kullanıcı Arayüzü Bitiş =============================//
    }
}
