namespace ZooPandica.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Slika { get; set; } // Putanja do slike
        public int BrojLajkova { get; set; }
    }
}