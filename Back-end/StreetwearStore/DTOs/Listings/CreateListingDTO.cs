
namespace StreetwearStore.Web.DTOs.Listings
{
    public class CreateListingDTO
    {
        public int ProductId { get; set; }

        public int SizeId { get; set; }

        public int Condition { get; set; }

        public decimal Price { get; set; }
    }
}
