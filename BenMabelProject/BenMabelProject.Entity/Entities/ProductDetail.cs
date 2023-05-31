namespace BenMabelProject.Entity.Entities
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? detail { get; set; }
        public Product? Product { get; set; }
    }
}
