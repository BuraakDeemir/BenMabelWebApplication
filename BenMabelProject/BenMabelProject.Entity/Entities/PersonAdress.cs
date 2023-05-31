namespace BenMabelProject.Entity.Entities
{
    public class PersonAdress
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string? Ctiy { get; set; }
        public string? District { get; set; }
        public string? Neighbourhood { get; set; }
        public string? Street { get; set; }
        public string? Detail { get; set; }
        public Person? Person { get; set; }
    }
}
