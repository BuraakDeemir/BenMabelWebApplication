namespace BenMabelProject.Entity.Entities
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public double KDV { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
