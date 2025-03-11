namespace ZooPandica.Models
{
    public class Event
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public required DateTime Date { get; set; }
    }
}