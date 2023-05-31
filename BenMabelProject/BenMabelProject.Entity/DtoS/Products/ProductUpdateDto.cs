using BenMabelProject.Entity.DtoS.Category;
using BenMabelProject.Entity.Entities;
using Microsoft.AspNetCore.Http;

namespace BenMabelProject.Entity.DtoS.Products
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public IFormFile? Img1 { get; set; }
        public IFormFile? Img2 { get; set; }
        public IFormFile? Img3 { get; set; }
        public IFormFile? Img4 { get; set; }
        public IList<CategoryDto> Categories { get; set; }
        public ProductPrice? ProductPrice { get; set; }
        public ProductImg? ProductImg { get; set; }
        public ProductDetail? ProductDetail { get; set; }
    }
}
