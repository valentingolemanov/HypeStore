using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StreetwearStore.Services.Categories
{
    public interface ICategoriesService
    {
        ICollection<TModel> GetCategories<TModel>();

        Task<int> CreateAsync(string name, string description, string imageUrl);

        TModel GetById<TModel>(int id);

        Task Delete(int id);
    }
}
