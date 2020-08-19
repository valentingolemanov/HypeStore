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

        public ICollection<TModel> GetProducts<TModel>()
        {
            return this.repository.All().To<TModel>().ToList();
        }
    }
}
