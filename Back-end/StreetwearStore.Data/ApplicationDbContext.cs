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
            modelBuilder.Entity<Brand>().HasData(
                 new Brand { Id = 1, Name="Nike", CreatedOn = DateTime.UtcNow },
                 new Brand { Id =2 , Name = "Adidas", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 3, Name = "Air Jordan", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 4, Name = "Alexander McQueen", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 5, Name = "Supreme", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 6, Name = "Dior", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 7, Name = "Off-White", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 8, Name = "Yeezy", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 9, Name = "Puma", CreatedOn = DateTime.UtcNow },
                 new Brand { Id = 10,  Name = "Palm Angels", CreatedOn = DateTime.UtcNow}
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

        public DbSet<Listing> Offers { get; set; }
    }
}
