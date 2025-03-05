namespace ZooPandica.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public int PosetilacID { get; set; }
        public string Tip { get; set; }
        public decimal Cena { get; set; }
        public string Status { get; set; }
    }
}