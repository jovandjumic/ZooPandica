namespace ZooPandica.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        public required string Description { get; set; }
    }
}