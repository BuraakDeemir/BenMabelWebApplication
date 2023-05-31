using AutoMapper;
using BenMabelProject.Data.UnitOfWorks;
using BenMabelProject.Entity.DtoS.Category;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Services.Services.Abstractions;

namespace BenMabelProject.Services.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        } 
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Menüde Tüm Kategorilerin Listelenme işlemini gerçekleştirir.
        /// </summary>
        public async Task<List<CategoryDto>> GetAllCategories()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync();
            var map = mapper.Map<List<CategoryDto>>(categories);
            return map;
        }
    }
}
