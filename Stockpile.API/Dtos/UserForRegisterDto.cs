using System;
using System.ComponentModel.DataAnnotations;

namespace Stockpile.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage =  "You must specify password between 4 and 8 characters")]
        public string Password { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string  City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Platforms { get; set; }
        public DateTime AccountCreated { get; set; }
        public DateTime LastActive { get; set; }
        public UserForRegisterDto() 
        {
            AccountCreated = DateTime.Now;
            LastActive = DateTime.Now;
        }
        
    }
}