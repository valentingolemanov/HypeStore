namespace StreetwearStore.Services.ProductCollections
{
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Repository;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProductsCollectionsService : IProductsCollectionsService
    {
        private readonly IDeletableEntityRepository<ProductCollection> repository;

        public ProductsCollectionsService(IDeletableEntityRepository<ProductCollection> repository)
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(int productId, int collectionId)
        {
            var productCollection = this.GetByIds(productId, collectionId);
            if(productCollection != null)
            {
                return -1;
            }

            productCollection = new ProductCollection
            {
                ProductId = productId,
                CollectionId = collectionId
            };

            await this.repository.AddAsync(productCollection);
            await this.repository.SaveChangesAsync();

            return productCollection.Id;
        }

        public async Task Delete(int productId, int collectionId)
        {
            var productCollection = this.GetByIds(productId, collectionId);
            if(productCollection == null)
            {
                return;
            }

            this.repository.Delete(productCollection);
            await this.repository.SaveChangesAsync();
        }

        public TModel GetById<TModel>(int id, int collectionId)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<TModel> GetProducts<TModel>()
        {
            throw new System.NotImplementedException();
        }

        private ProductCollection GetByIds(int productId, int collectionId)
        {
            return this.repository.All()
                .FirstOrDefault(x => x.ProductId == productId && x.CollectionId == collectionId);
        }
    }
}
