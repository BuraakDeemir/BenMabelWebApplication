using BenMabelProject.Entity.DtoS.Products;
using BenMabelProject.Entity.Entities;

namespace BenMabelProject.Services.Services.Abstractions
{
    public interface IProductService
    {
        // =========================== Admin Area Başlangıç ===============================//

        Task<List<Product>> GetAllProductForAdmin();
        Task<ProductUpdateDto> GetProduct(int productId);
        Task AddProductAsync(ProductAddDto productAddDto);
        Task<string> UpdateProduct(ProductUpdateDto productUpdateDto);
        Task<List<Product>> GetAllProductForRemove();
        Task<string> SafeDeleteProduct(int productId);
        Task<List<Product>> GetAllProductForActive();
        Task<string> AgainSaleProduct(int productId);

        // =========================== Admin Area Bitiş ===================================//





        // ======================= Kullanıcı Arayüzü Başlangıç ============================//
        Task<List<ProductDto>> GetAllProduct();
        Task<List<ProductDto>> GetCategoryProduct(int CategoryId);
        Task<ProductDto> GetProductById(int ProductId);





        // ========================== Kullanıcı Arayüzü Bitiş =============================//
    }
}
