
namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;


    public class ListingImage : BaseDeletableModel<int>
    {
        public string Url { get; set; }

        public int ListingId { get; set; }

        public Listing Listing { get; set; }
    }
}
