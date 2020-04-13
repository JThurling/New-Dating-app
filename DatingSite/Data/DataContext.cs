using DatingSite.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingSite.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Values> Values { get; set; }
    }
}