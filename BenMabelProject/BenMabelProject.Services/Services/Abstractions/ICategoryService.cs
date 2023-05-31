using BenMabelProject.Entity.DtoS.Category;

namespace BenMabelProject.Services.Services.Abstractions
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllCategories();
    }
}
