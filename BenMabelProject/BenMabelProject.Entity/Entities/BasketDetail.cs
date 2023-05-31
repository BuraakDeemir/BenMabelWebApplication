namespace BenMabelProject.Entity.Entities
{
    public class BasketDetail
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double Piece { get; set; }
        public decimal Price { get; set; }
        public double KDV { get; set; }
        public decimal TotalPrice { get; set; }
        public Basket? Basket { get; set; }
        public Product? Product { get; set; }
    }
}
