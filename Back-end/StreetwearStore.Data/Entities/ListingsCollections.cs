namespace StreetwearStore.Data.Entities
{
    public class ListingsCollections 
    {
        public int ProductId { get; set; }

        public Listing Product { get; set; }

        public int CollectionId { get; set; }

        public Collection Collection { get; set; }
    }
}
