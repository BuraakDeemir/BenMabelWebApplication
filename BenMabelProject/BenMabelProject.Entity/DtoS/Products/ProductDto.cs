using BenMabelProject.Entity.Entities;

namespace BenMabelProject.Entity.DtoS.Products
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int CategoryId { get; set; }
        public BenMabelProject.Entity.Entities.Category Category { get; set; }
        public int Adet { get; set; }
        public ProductPrice ProductPrice { get; set; }
        public ProductImg ProductImg { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
