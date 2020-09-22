namespace StreetwearStore.Services.ProductCollections
{
    using StreetwearStore.Data.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductsCollectionsService
    {
        ICollection<TModel> GetProducts<TModel>();

        Task<ProductCollection> CreateAsync(int productId, int collectionId);

        TModel GetById<TModel>(int id, int collectionId);

        Task Delete(int id, int collectionId);
    }
}
