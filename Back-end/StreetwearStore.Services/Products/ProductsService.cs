namespace StreetwearStore.Services.Products
{

    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Repository;
    using StreetwearStore.Services.Mapping;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProductsService : IProductsService
    {
        private readonly IDeletableEntityRepository<Product> repository;

        public ProductsService(IDeletableEntityRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(string name, string description, string imageUrl, decimal price, int brandId)
        {
            var product = new Product
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
                Price = price,
                BrandId = brandId
            };

            await this.repository.AddAsync(product);
            await this.repository.SaveChangesAsync();

            return product.Id;
        }

        public TModel GetById<TModel>(int id)
        {
            return this.repository.All()
                .Where(x => x.Id == id)
                .To<TModel>()
                .FirstOrDefault();
        }

        public ICollection<TModel> GetProducts<TModel>()
        {
            return this.repository.All()
                .To<TModel>()
                .ToList();
        }
    }
}
