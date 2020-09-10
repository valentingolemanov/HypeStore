using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StreetwearStore.Services.Products
{
    public interface IProductsService
    {
      ICollection<TModel> GetProducts<TModel>();

      Task<int> CreateAsync(string name, string description, string imageUrl, decimal price, int brandId);

      TModel GetById<TModel>(int id);
    }
}
