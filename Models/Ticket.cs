namespace ZooPandica.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public required int UserID { get; set; }
        public string? PromoCode { get; set; }
        public required string Type { get; set; }
        public required decimal Price { get; set; }
        public required string Status { get; set; }
    }
}