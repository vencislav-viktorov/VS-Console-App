using Microsoft.EntityFrameworkCore;
using TeisterMask.Models;

namespace TeisterMask.Data
{
    public class TeisterMaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS01;Database=TeisterMaskDb;Trusted_Connection=True;");
        }
    }
}
