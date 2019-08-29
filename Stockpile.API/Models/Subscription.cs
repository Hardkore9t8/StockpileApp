namespace Stockpile.API.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string SubcriptionName { get; set; }
        public int Price { get; set; }
        public int SubcriptionDuration { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}