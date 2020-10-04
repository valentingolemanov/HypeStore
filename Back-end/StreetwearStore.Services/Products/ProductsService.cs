namespace StreetwearStore.Services.Products
{
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
        private readonly IProductCollectionsService productsCollectionsService;

        public ProductsService(IDeletableEntityRepository<Product> repository,
            IProductCollectionsService productsCollectionsService)
        {
            this.repository = repository;
            this.productsCollectionsService = productsCollectionsService;
        }

        public async Task<int> CreateAsync(string name, string description, List<string> imagesUrl,
           int brandId, List<int> collectionIds)
        {
            var product = new Product
            {
                Name = name,
                Description = description,
                BrandId = brandId,
                CreatedOn = DateTime.UtcNow
            };

            await this.repository.AddAsync(product);
            await this.repository.SaveChangesAsync();

            foreach (var collectionId in collectionIds)
            {
        
                var productCollection = new ProductCollection
                {
                    CollectionId = collectionId,
                    ProductId = product.Id
                };

                product.ProductCollections.Add(productCollection);
            }

            foreach (var imageUrl in imagesUrl)
            {
                //await this.productImagesService.CreateAsync(product.Id, imageUrl);
                var productImage = new ProductImage
                {
                    Path = imageUrl,
                    ProductId = product.Id
                };

                product.ProductImages.Add(productImage);
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

        public async Task Update(int id, string name, string description, List<string> imagesUrl, int brandId, List<int> collectionIds)
        {
            var product = this.GetById(id);

            product.Name = name;
            product.Description = description;
            product.BrandId = brandId;

            await this.productsCollectionsService.ClearProductCollections(product.Id);

            foreach (var collectionId in collectionIds)
            {
                await this.productsCollectionsService.CreateAsync(product.Id, collectionId);
            }

            this.repository.Update(product);
            await this.repository.SaveChangesAsync();


        }
    }
}
