using BenMabelProject.Entity.DtoS.Images;
using BenMabelProject.Entity.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BenMabelProject.Services.Helpers.Images
{
    public class ImageHelper : IImageHelper
    {
        private readonly string wwwroot;
        private readonly IWebHostEnvironment env;
        private const string imgFolder = "images";
        private const string ProductImgFolder = "ProductImages";
        private const string UserImgFolder = "UserImages";

        public ImageHelper(IWebHostEnvironment env)
        {
            this.env = env;
            wwwroot = env.WebRootPath;

        }

        private string ReplaceInvalidChars(string fileName)
        {
            return fileName.Replace("İ", "I")
                 .Replace("ı", "i")
                 .Replace("Ğ", "G")
                 .Replace("ğ", "g")
                 .Replace("Ü", "U")
                 .Replace("ü", "u")
                 .Replace("ş", "s")
                 .Replace("Ş", "S")
                 .Replace("Ö", "O")
                 .Replace("ö", "o")
                 .Replace("Ç", "C")
                 .Replace("ç", "c")
                 .Replace("é", "")
                 .Replace("!", "")
                 .Replace("'", "")
                 .Replace("^", "")
                 .Replace("+", "")
                 .Replace("%", "")
                 .Replace("/", "")
                 .Replace("(", "")
                 .Replace(")", "")
                 .Replace("=", "")
                 .Replace("?", "")
                 .Replace("_", "")
                 .Replace("*", "")
                 .Replace("æ", "")
                 .Replace("ß", "")
                 .Replace("@", "")
                 .Replace("€", "")
                 .Replace("<", "")
                 .Replace(">", "")
                 .Replace("#", "")
                 .Replace("$", "")
                 .Replace("½", "")
                 .Replace("{", "")
                 .Replace("[", "")
                 .Replace("]", "")
                 .Replace("}", "")
                 .Replace(@"\", "")
                 .Replace("|", "")
                 .Replace("~", "")
                 .Replace("¨", "")
                 .Replace(",", "")
                 .Replace(";", "")
                 .Replace("`", "")
                 .Replace(".", "")
                 .Replace(":", "")
                 .Replace(" ", "");
        }
        public async Task<ImageUpluadedDto> Upload(string Name, IFormFile imageFile, ImageType imageType, string FolderName = null)
        {
            FolderName ??= imageType == ImageType.User ? UserImgFolder : ProductImgFolder;
            if (!Directory.Exists($"{wwwroot}/{imgFolder}/{FolderName}"))
            {
                Directory.CreateDirectory($"{wwwroot}/{imgFolder}/{FolderName}");
            }
            string OldFileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
            string FileExtension = Path.GetExtension(imageFile.FileName);
            Name = ReplaceInvalidChars(Name);
            DateTime dateTime = DateTime.Now;
            string NewFileName = $"{Name}_{dateTime.Millisecond}{FileExtension}";

            var path = Path.Combine($"{wwwroot}/{imgFolder}/{FolderName}", NewFileName);

            await using var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
            await imageFile.CopyToAsync(stream);
            await stream.FlushAsync();

            string message = imageType == ImageType.User
                ? $"{NewFileName} isimli Kullanıcı resmi başarılı bir şekilde eklenmiştir."
                : $"{NewFileName} isimli Ürün resmi başarılı bir şekilde eklenmiştir.";
            return new ImageUpluadedDto
            {
                FullName = $"{FolderName}/{NewFileName}"
            };

        }
        public void Delete(string ImageName)
        {
            var FileToDetele = Path.Combine($"{wwwroot}/{imgFolder}/{ImageName}");
            if (File.Exists(FileToDetele))
                File.Delete(FileToDetele);
        }
    }
}
