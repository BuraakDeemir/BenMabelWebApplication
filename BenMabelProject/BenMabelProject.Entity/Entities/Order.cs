namespace BenMabelProject.Entity.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int Stuation { get; set; }
        public Person? Person { get; set; }
        public ICollection<OrderDetail>? OrderDetail { get; set; }
        public OrderSituation? OrderSituation { get; set; }
        public OrderPrice? OrderPrice { get; set; }
    }
}
