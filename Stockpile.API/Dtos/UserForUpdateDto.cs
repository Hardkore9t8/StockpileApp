namespace Stockpile.API.Dtos
{
    public class UserForUpdateDto
    {
        public string LastName { get; set; }
        public string Address { get; set; }
        public string  City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Platforms { get; set; }
    }
}