namespace ToDoList.Data
{
    using Microsoft.EntityFrameworkCore;
    using ToDoList.Models;

    public class ToDoDbContext : DbContext
    {
        private const string ConnectionString = @"Server=localhost\SQLEXPRESS01;Database=ToDoList;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public virtual DbSet<Task> Tasks { get; set; }
    }
}
