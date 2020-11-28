
using StreetwearStore.Data.Entities;
using System.Threading.Tasks;

namespace StreetwearStore.Services.ProductCollections
{
    public interface IListingsCollectionsService
    {
        Task CreateAsync(int productId, int collectionId);

        void Delete(ListingsCollections productCollection);

        Task ClearProductCollections(int productId);
    }
}
