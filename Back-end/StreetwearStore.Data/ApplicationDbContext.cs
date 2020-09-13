namespace StreetwearStore.Data
{
    using Microsoft.EntityFrameworkCore;
    using StreetwearStore.Data.Entities;
    using System.Net;
    using System.Net.Http.Headers;
    using System.Security.Cryptography.X509Certificates;

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                 new Brand {Id = 1, Name="Nike" },
                 new Brand {Id =2 , Name = "Adidas" },
                 new Brand { Id = 3, Name = "Air Jordan" },
                 new Brand { Id = 4, Name = "Alexander McQueen" },
                 new Brand { Id = 5, Name = "Supreme" },
                 new Brand { Id = 6, Name = "Dior" },
                 new Brand { Id = 7, Name = "Off-White" },
                 new Brand { Id = 8, Name = "Yeezy" },
                 new Brand { Id = 9, Name = "Puma"}
                 );
       
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Collection> Collections { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
