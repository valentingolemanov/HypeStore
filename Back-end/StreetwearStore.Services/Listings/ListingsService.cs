namespace StreetwearStore.Services.Listings
{
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Entities.Enums;
    using StreetwearStore.Data.Repository;
    using StreetwearStore.Services.Mapping;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ListingsService : IListingsService
    {
        private readonly IDeletableEntityRepository<Listing> repository;

        public ListingsService(IDeletableEntityRepository<Listing> repository)
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(int productId, int sizeId, int condition, decimal price)
        {
            var listing = new Listing
            {
                ProductId = productId,
                SizeId = sizeId,
                Condition = (Condition)condition,
                Price = price
            };

            await this.repository.AddAsync(listing);
            await this.repository.SaveChangesAsync();

            return listing.Id;
        }

        public async Task Delete(int id)
        {
            var listing = this.GetListing(id);

            this.repository.Delete(listing);
            await this.repository.SaveChangesAsync();
        }

        public async Task<int> EditAsync(int id, int productId, int sizeId, int condition, decimal price)
        {
            var listing = this.GetListing(id);

            listing.ProductId = productId;
            listing.SizeId = sizeId;
            listing.Condition = (Condition)condition;
            listing.Price = price;

            this.repository.Update(listing);
            await this.repository.SaveChangesAsync();

            return listing.Id;

        }

        public TModel GetById<TModel>(int id)
        {
            return this.repository.All().Where(x => x.Id == id).To<TModel>().FirstOrDefault();
        }

        public ICollection<TModel> GetListings<TModel>()
        {
            return this.repository.All().To<TModel>().ToList();
        }

        private Listing GetListing(int id)
        {
            return this.repository.All().FirstOrDefault(x => x.Id == id);
        }
    }
}
