using Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Data
{
    public class DatabaseWebAPIContext: DbContext
    {
        public DatabaseWebAPIContext(DbContextOptions options)
       : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Banking> Bangkings { get; set; }
    }
}
