using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StreetwearStore.Services.Products
{
    public interface IProductsService
    {
      ICollection<TModel> GetProducts<TModel>();
    }
}
