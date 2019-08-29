using System;
using System.Collections.Generic;

namespace Stockpile.API.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemBrand { get; set; }
        public string ItemSize { get; set; }
        public int ItemQty { get; set; }
        public string ItemColor { get; set; }
        public string ItemPlatform { get; set; }    
        public bool isNew { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public ICollection<ItemPhoto> ItemPhotos { get; set; }
        public User User { get; set; }  
        public int UserId { get; set; }
        
    }
}