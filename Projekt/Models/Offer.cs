namespace Projekt.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
