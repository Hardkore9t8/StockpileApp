using System.Collections.Generic;
using System.Threading.Tasks;
using Stockpile.API.Models;

namespace Stockpile.API.Data
{
    public interface IStockpileRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
         Task<IEnumerable<Inventory>> GetItems();
         Task<Inventory> GetItem(int id);

    }
}