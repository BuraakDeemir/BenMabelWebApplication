namespace BenMabelProject.Entity.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        public ICollection<BasketDetail>? BasketDetail { get; set; }
    }
}
