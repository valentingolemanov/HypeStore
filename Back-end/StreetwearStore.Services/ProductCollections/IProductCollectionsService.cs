
using StreetwearStore.Data.Entities;
using System.Threading.Tasks;

namespace StreetwearStore.Services.ProductCollections
{
    public interface IProductCollectionsService
    {
        Task CreateAsync(int productId, int collectionId);

        void Delete(ProductCollection productCollection);

        Task ClearProductCollections(int productId);
    }
}
