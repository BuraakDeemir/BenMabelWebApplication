namespace BenMabelProject.Entity.Entities
{
    public class PersonIphone
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string? Iphone { get; set; }
        public Person? Person { get; set; }
    }
}
