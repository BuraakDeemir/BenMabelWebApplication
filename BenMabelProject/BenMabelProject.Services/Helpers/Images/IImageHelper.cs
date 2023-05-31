using BenMabelProject.Entity.DtoS.Images;
using BenMabelProject.Entity.Enums;
using Microsoft.AspNetCore.Http;

namespace BenMabelProject.Services.Helpers.Images
{
    public interface IImageHelper
    {
        Task<ImageUpluadedDto> Upload(string Name, IFormFile imageFile, ImageType imageType, string FolderName = null);
        void Delete(string ImageName);
    }
}
