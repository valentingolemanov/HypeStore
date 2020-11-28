namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;
    using System.Collections.Generic;

    public class Listing : BaseDeletableModel<int>
    {
        public Listing()
        {
            this.ProductCollections = new HashSet<ListingsCollections>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public string Colorway { get; set; }

        public int? Quantity { get; set; }

        public ICollection<ListingsCollections> ProductCollections { get; set; }

        public ICollection<ListingImage> ListingImages { get; set; }

    }
}
