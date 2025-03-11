namespace ZooPandica.Models
{
    public class User
    {
        public int ID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public required string Role { get; set; }
    }
}