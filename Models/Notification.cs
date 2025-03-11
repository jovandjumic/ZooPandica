namespace ZooPandica.Models
{
    public class Notification
    {
        public int ID { get; set; }
        public required int UserID { get; set; }
        public required string Message { get; set; }
    }
}