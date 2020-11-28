

namespace StreetwearStore.Services.ListingImages
{
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Data.Repository;

    using System.Collections.Generic;

    using System.Threading.Tasks;

    public class ListingImageService : IListingImageService
    {
        private readonly IDeletableEntityRepository<ListingImage> repository;

        public ListingImageService(IDeletableEntityRepository<ListingImage> repository)
        {
            this.repository = repository;
        }

        public async Task UploadImagesAsync(int listingId, List<string> imagePaths)
        {
            foreach(var path in imagePaths)
            {
                var listingImage = new ListingImage
                {
                    Url = path,
                    ListingId = listingId
                };

               await this.repository.AddAsync(listingImage);
            }

            await this.repository.SaveChangesAsync();
                
        }
    }

}