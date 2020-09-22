namespace StreetwearStore.Services.Collections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Repository;
    using StreetwearStore.Services.Mapping;

    public class CollectionsService : ICollectionsService
    {
        private IDeletableEntityRepository<Collection> repository;

        public CollectionsService(IDeletableEntityRepository<Collection> repository) 
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(string name, string description, string imageUrl, bool homeDisplay, int displayRows, int displayCols, int displayPositionIndex)
        {
            var collection = this.GetCollectionByName(name);

            if(collection != null)
            {
                return -1;
            }

            collection = new Collection
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
                CreatedOn = DateTime.UtcNow,
                HomeDisplay = homeDisplay, 
                DisplayCols = displayCols, 
                DisplayRows = displayRows,
                DisplayPositionIndex = displayPositionIndex
            };

            await this.repository.AddAsync(collection);
            await this.repository.SaveChangesAsync();

            return collection.Id;
        }

        public async Task Delete(int id)
        {
            var collection = this.GetCollectionById(id);

            if (collection == null)
            {
                return;
            }

            this.repository.Delete(collection);
            await this.repository.SaveChangesAsync();
        }

        public TModel GetById<TModel>(int id)
        {
            return this.repository.All()
                .Where(x => x.Id == id)
                .To<TModel>()
                .FirstOrDefault();
        }

        public ICollection<TModel> GetCollections<TModel>()
        {
            return this.repository.All()
                .To<TModel>()
                .ToList();
        }

        private Collection GetCollectionByName(string name)
        {
            return this.repository.All()
                .FirstOrDefault(x => x.Name == name);
        }

        private Collection GetCollectionById(int id)
        {
            return this.repository.All()
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
