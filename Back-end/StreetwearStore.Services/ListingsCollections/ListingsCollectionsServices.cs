using Microsoft.EntityFrameworkCore.Internal;
using StreetwearStore.Data.Entities;
using StreetwearStore.Data.Repository;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace StreetwearStore.Services.ProductCollections
{
    public class ListingsCollectionsServices : IListingsCollectionsService
    {
        private readonly IRepository<ListingsCollections> repository;

        public ListingsCollectionsServices(IRepository<ListingsCollections> repository)
        {
            this.repository = repository;
        }

        public async Task CreateAsync(int productId, int collectionId)
        {
            var productCollection = this.GetProductCollection(productId, collectionId);
            if (productCollection != null)
            {
                return;
            }

            productCollection = new ListingsCollections
            {
                ProductId = productId,
                CollectionId = collectionId
            };

            await this.repository.AddAsync(productCollection);
            await this.repository.SaveChangesAsync();
        }

        public void Delete(ListingsCollections productCollection)
        {
           
            if (productCollection == null)
            {
                return;
            }

            this.repository.Delete(productCollection);
         
        }

        public async Task ClearProductCollections(int productId)
        {
            var productCollections = this.repository.All()
                .Where(x => x.ProductId == productId);

            foreach (var productCollection in productCollections)
            {
                 this.Delete(productCollection);
            }

            await this.repository.SaveChangesAsync();
        
        }

        private ListingsCollections GetProductCollection(int productId, int collectionId)
        {
            return this.repository.All()
                .FirstOrDefault(x => x.ProductId == productId && x.CollectionId == collectionId);
        }
    }
}
