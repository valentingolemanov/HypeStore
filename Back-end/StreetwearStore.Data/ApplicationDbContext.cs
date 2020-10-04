namespace StreetwearStore.Data
{
    using Microsoft.EntityFrameworkCore;
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Entities.Enums;
    using System;

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Size>().HasData(
                new Size { Id = 1, UK = 5.5, EU = 38.5, US = 6, CreatedOn = DateTime.UtcNow },
                new Size { Id = 2, UK = 6, EU = 39, US = 6.5, CreatedOn = DateTime.UtcNow },
                new Size { Id = 3, UK = 6.5, EU = 40.5, US = 7.5, CreatedOn = DateTime.UtcNow },
                new Size { Id = 4, UK = 7, EU = 41, US = 8, CreatedOn = DateTime.UtcNow },
                new Size { Id = 5, UK = 7.5, EU = 42, US = 8.5, CreatedOn = DateTime.UtcNow },
                new Size { Id = 6, UK = 8, EU = 42.5, US = 9, CreatedOn = DateTime.UtcNow },
                new Size { Id = 7, UK = 8.5, EU = 43, US = 9.5, CreatedOn = DateTime.UtcNow },
                new Size { Id = 8, UK = 9, EU = 44, US = 10, CreatedOn = DateTime.UtcNow },
                new Size { Id = 9, UK = 9.5, EU = 44.5, US = 10.5, CreatedOn = DateTime.UtcNow },
                new Size { Id = 10, UK = 10, EU = 45, US = 11, CreatedOn = DateTime.UtcNow },
                new Size { Id = 11, UK = 10.5, EU = 45.5, US = 11.5, CreatedOn = DateTime.UtcNow },
                new Size { Id = 12, UK = 11, EU = 46, US = 12, CreatedOn = DateTime.UtcNow },
                new Size { Id = 13, UK = 11.5 , EU = 47, US = 12.5, CreatedOn = DateTime.UtcNow },
                new Size { Id = 14, UK = 12, EU = 47.5, US = 13, CreatedOn = DateTime.UtcNow },
                new Size { Id = 15, UK = 12.5, EU = 48, US = 13.5, CreatedOn = DateTime.UtcNow },
                new Size { Id = 16, UK = 13, EU = 48.5, US = 14, CreatedOn = DateTime.UtcNow },
                new Size { Id = 17, UK = 13.5, EU = 49, US = 14.5, CreatedOn = DateTime.UtcNow },
                new Size { Id = 18, UK = 14, EU = 49.5, US = 15, CreatedOn = DateTime.UtcNow },
                new Size { Id = 19, UK = 15, EU = 50.5, US = 16, CreatedOn = DateTime.UtcNow }
                );

            modelBuilder.Entity<Brand>().HasData(
                 new Brand { Id = 1, Name = "Nike", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 2, Name = "Adidas", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 3, Name = "Air Jordan", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 4, Name = "Alexander McQueen", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 5, Name = "Supreme", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 6, Name = "Dior", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 7, Name = "Off-White", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 8, Name = "Yeezy", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 9, Name = "Puma", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 10, Name = "Palm Angels", CreatedOn = DateTime.UtcNow }
                 );

            modelBuilder.Entity<ProductCollection>()
                .HasKey(x => new { x.ProductId, x.CollectionId });


        }


        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Collection> Collections { get; set; }

        public DbSet<ProductCollection> ProductCollections { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Listing> Listings { get; set; }
    }
}
