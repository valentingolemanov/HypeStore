namespace StreetwearStore.Services.Products
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IListingsService
    {
      ICollection<TModel> GetProducts<TModel>();

      Task<int> CreateAsync(string name, string description, int brandId);

      TModel GetById<TModel>(int id);

      Task Update(int id, string name, string description, List<string> imagesUrl, int brandId, List<int> collectionIds);

      Task Delete(int id);

    }
}
