
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StreetwearStore.Services.ListingImages
{
    public interface IListingImageService
    {
        Task UploadImagesAsync(int listingId, List<string> imagePaths);
    }
}

