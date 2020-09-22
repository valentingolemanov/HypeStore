namespace StreetwearStore.Services.Products
{
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Repository;
    using StreetwearStore.Services.Mapping;
    using StreetwearStore.Services.ProductCollections;
    using StreetwearStore.Services.ProductImages;
    using System;
    using System.Collections.Generic;

    using System.Linq;
    using System.Threading.Tasks;

    public class ProductsService : IProductsService
    {
        private readonly IDeletableEntityRepository<Product> repository;
        private readonly IProductsCollectionsService productsCollectionsService;
        private readonly IProductImageService productImagesService;

        public ProductsService(IDeletableEntityRepository<Product> repository,
            IProductsCollectionsService productCollectionsService,
            IProductImageService productImagesService)
        {
            this.repository = repository;
            this.productsCollectionsService = productCollectionsService;
            this.productImagesService = productImagesService;
        }

        public async Task<int> CreateAsync(string name, string description, List<string> imagesUrl,
            decimal price, int brandId, List<int> collectionIds)
        {
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                BrandId = brandId,
                CreatedOn = DateTime.UtcNow
            };

            await this.repository.AddAsync(product);
            await this.repository.SaveChangesAsync();

            foreach (var collectionId in collectionIds)
            {
                await this.productsCollectionsService.CreateAsync(product.Id, collectionId);
            }

            foreach (var imageUrl in imagesUrl)
            {
                await this.productImagesService.CreateAsync(product.Id, imageUrl);
            }

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

        public async Task<int> EditAsync(int id, string name, string description, List<string> imagesUrl, decimal price, int brandId, List<int> collectionIds)
        {
            var product = this.GetById(id);


            product.Name = name;
            product.Description = description;
            product.Price = price;
            product.BrandId = brandId;

            this.repository.Update(product);
            await this.repository.SaveChangesAsync();

            return product.Id;

        }
    }
}
