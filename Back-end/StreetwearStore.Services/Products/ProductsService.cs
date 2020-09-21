namespace StreetwearStore.Services.Products
{
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Repository;
    using StreetwearStore.Services.Mapping;
    using StreetwearStore.Services.ProductCollections;
    using System;
    using System.Collections.Generic;

    using System.Linq;
    using System.Threading.Tasks;

    public class ProductsService : IProductsService
    {
        private readonly IDeletableEntityRepository<Product> repository;
        private readonly IProductsCollectionsService productsCollectionsService;

        public ProductsService(IDeletableEntityRepository<Product> repository,
            IProductsCollectionsService service)
        {
            this.repository = repository;
            this.productsCollectionsService = service;
        }

        public async Task<int> CreateAsync(string name, string description, string imageUrl,
            decimal price, int brandId, List<int> collectionIds)
        {
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                ImageUrl = imageUrl,
                BrandId = brandId,
                CreatedOn = DateTime.UtcNow
            };

            foreach(var collectionId in collectionIds)
            {
                var productCollection = this.productsCollectionsService.CreateAsync(product.Id, collectionId);
                if(productCollection != null)
                {
                    product.ProductCollections.Add(productCollection);
                }
            }

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

        public async Task Delete(int id)
        {
            var product = this.GetById(id);

            if(product == null)
            {
                return;
            }

           this.repository.Delete(product);
           await this.repository.SaveChangesAsync();
        }

        private Product GetById(int id)
        {
            return this.repository.All().FirstOrDefault(x => x.Id == id);
        }

        public async Task<int> EditAsync(int id, string name, string description, string imageUrl, decimal price, int brandId, List<int> collectionIds)
        {
            var product = this.GetById(id);


            product.Name = name;
            product.Description = description;
            product.ImageUrl = imageUrl;
            product.Price = price;
            product.BrandId = brandId;

            this.repository.Update(product);
            await this.repository.SaveChangesAsync();

            return product.Id;

        }
    }
}
