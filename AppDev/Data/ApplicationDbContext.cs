using AppDev.Models;
using Microsoft.EntityFrameworkCore;

namespace AppDev.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Adventure", Description = "So funny" },
            new Category { Id = 2, Name = "Action", Description = "So awsome" },
            new Category { Id = 3, Name = "Horror", Description = "So scared" }
            );
        }
    }
}