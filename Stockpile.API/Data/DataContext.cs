using Microsoft.EntityFrameworkCore;
using Stockpile.API.Models;

namespace Stockpile.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Value> Values { get; set; }
    }
}