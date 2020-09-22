
namespace StreetwearStore.Services.ProductImages
{
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Repository;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductImageService : IProductImageService
    {
        private readonly IDeletableEntityRepository<ProductImage> repository;

        public ProductImageService(IDeletableEntityRepository<ProductImage> repository)
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(int productId, string imagePath)
        {
            var productImage = new ProductImage
            {
                Path = imagePath,
                ProductId = productId,
                CreatedOn = DateTime.UtcNow
            };

            await this.repository.AddAsync(productImage);
            await this.repository.SaveChangesAsync();

            return productImage.Id;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TModel GetById<TModel>(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<TModel> GetProductImages<TModel>()
        {
            throw new NotImplementedException();
        }
    }
}
