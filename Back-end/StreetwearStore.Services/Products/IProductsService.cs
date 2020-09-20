namespace StreetwearStore.Services.Products
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductsService
    {
      ICollection<TModel> GetProducts<TModel>();

      Task<int> CreateAsync(string name, string description, string imageUrl, decimal price, int brandId, List<int> collectionIds);

      TModel GetById<TModel>(int id);

      Task Delete(int id);
    }
}
