using System;
using Stockpile.API.Models;

namespace Stockpile.API.Dtos
{
    public class InventoryListDto
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
        public string ItemPhotosUrl { get; set; }
        
    }
}