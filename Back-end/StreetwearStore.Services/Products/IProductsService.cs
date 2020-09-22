namespace StreetwearStore.Services.Products
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductsService
    {
      ICollection<TModel> GetProducts<TModel>();

      Task<int> CreateAsync(string name, string description, List<string> imagesUrl, decimal price, int brandId, List<int> collectionIds);

      TModel GetById<TModel>(int id);

      Task<int> EditAsync(int id, string name, string description, List<string> imageUrl, decimal price, int brandId, List<int> collectionIds);

      Task Delete(int id);

      
    }
}
