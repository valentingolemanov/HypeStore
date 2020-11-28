namespace StreetwearStore.Services.Products
{
    using Microsoft.AspNetCore.Http;
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Repository;
    using StreetwearStore.Services.Mapping;
    using StreetwearStore.Services.ProductCollections;
    using System;
    using System.Collections.Generic;

    using System.Linq;
    using System.Threading.Tasks;

    public class ListingsService : IListingsService
    {
        private readonly IDeletableEntityRepository<Listing> repository;
        private readonly IListingsCollectionsService productsCollectionsService;

        public ListingsService(IDeletableEntityRepository<Listing> repository,
            IListingsCollectionsService productsCollectionsService)
        {
            this.repository = repository;
            this.productsCollectionsService = productsCollectionsService;
        }

        public async Task<int> CreateAsync(string name, string description,
           int brandId)
        {
            var product = new Listing
            {
                Name = name,
                Description = description,
                BrandId = brandId,
                CreatedOn = DateTime.UtcNow
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

        private Listing GetById(int id)
        {
            return this.repository.All().FirstOrDefault(x => x.Id == id);
        }

     

     
    }
}
