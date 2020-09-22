namespace StreetwearStore.Services.ProductImages
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IProductImageService
    {
        ICollection<TModel> GetProductImages<TModel>();

        Task<int> CreateAsync(int productId, string imagePath);

        TModel GetById<TModel>(int id);

        Task Delete(int id);
    }
}
