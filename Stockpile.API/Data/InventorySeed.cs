using System.Collections.Generic;
using Newtonsoft.Json;
using Stockpile.API.Models;

namespace Stockpile.API.Data
{
    public class InventorySeed
    {
        private readonly DataContext _context;
        public InventorySeed(DataContext context)
        {
            _context = context;
        }
        public void SeedItems() 
        {
            var itemData = System.IO.File.ReadAllText("Data/InventorySeedData.json");
            var items = JsonConvert.DeserializeObject<List<Inventory>>(itemData);
            foreach (var item in items)
            {
                _context.Items.Add(item);
            }
            _context.SaveChanges();
        }
    }
}
