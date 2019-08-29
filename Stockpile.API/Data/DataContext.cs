using Microsoft.EntityFrameworkCore;
using Stockpile.API.Models;

namespace Stockpile.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photo  { get; set; }
        public DbSet<Inventory> Items { get; set; }
   
    }
}