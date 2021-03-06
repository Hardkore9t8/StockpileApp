using System;
using System.Collections.Generic;


namespace Stockpile.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string  City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Platforms { get; set; }
        public DateTime AccountCreated { get; set; }
        public DateTime LastActive { get; set; }
        public int AccountAge { get; set; }
        public bool isActive { get; set; }
        public Subscription SubscriptionType { get; set; }
        public ICollection<Photo> Photo { get; set; }
        public ICollection<Inventory> Items { get; set; }

    }
}