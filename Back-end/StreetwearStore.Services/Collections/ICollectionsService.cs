namespace StreetwearStore.Services.Collections
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICollectionsService
    {
        ICollection<TModel> GetCollections<TModel>();

        Task<int> CreateAsync(string name, string description, string imageUrl);

        TModel GetById<TModel>(int id);

        Task Delete(int id);
    }
}
