using AppDev.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppDev.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Adventure", Description = "So funny", DisplayOrder = 12 },
            new Category { Id = 2, Name = "Action", Description = "So awsome", DisplayOrder = 19 },
            new Category { Id = 3, Name = "Horror", Description = "So scared", DisplayOrder = 22 }
            );

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "ABC", Description = "Amazing", Author = "DDA", Price = 1200, CategoryId = 1 },
                new Book { Id = 2, Title = "CVD", Description = "Horror", Author = "DAD", Price = 1900, CategoryId = 2 },
                new Book { Id = 3, Title = "OPA", Description = "SAd", Author = "NVM", Price = 1700, CategoryId = 3 }
                );
        }
    }
}