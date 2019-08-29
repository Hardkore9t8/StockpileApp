using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stockpile.API.Models;

namespace Stockpile.API.Data
{
    public class StockpileRepository : IStockpileRepository
    {
        private readonly DataContext _context;
        public StockpileRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Inventory> GetItem(int id)
        {
            var item = await _context.Items.Include(p => p.ItemPhotos).FirstOrDefaultAsync(u => u.Id == id);
            return item;
        }

        public async Task<IEnumerable<Inventory>> GetItems()
        {
            var items = await _context.Items.Include(p => p.ItemPhotos).ToListAsync();
            return items;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p => p.Photo).FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include(p => p.Photo).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}