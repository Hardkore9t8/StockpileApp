using System;
using Stockpile.API.Models;

namespace Stockpile.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime AccountCreated { get; set; }
        public DateTime LastActive { get; set; }
        public bool isActive { get; set; }
        public int AccountAge { get; set; }
        public Subscription SubscriptionType { get; set; }
        public string PhotoUrl { get; set; }
    }
}