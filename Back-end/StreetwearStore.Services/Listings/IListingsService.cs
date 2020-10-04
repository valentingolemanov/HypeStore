namespace StreetwearStore.Services.Listings
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IListingsService
    {
        ICollection<TModel> GetListings<TModel>();

        Task<int> CreateAsync(int productId, int sizeId, int condition, decimal price);

        TModel GetById<TModel>(int id);

        Task<int> EditAsync(int id, int productId, int sizeId, int condition, decimal price);

        Task Delete(int id);
    
    }
}
