namespace StreetwearStore.Data
{
    using Microsoft.EntityFrameworkCore;
    using StreetwearStore.Data.Entities;

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
