using System.Threading.Tasks;
using Stockpile.API.Models;

namespace Stockpile.API.Data
{
    public interface IAuthRepository
    {
        // This interface checks if user name has already been taken and checks username and password against database
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}