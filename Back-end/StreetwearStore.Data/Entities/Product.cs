namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;
    using System.Collections.Generic;

    public class Product : BaseDeletableModel<int>
    {
        public Product()
        {
            this.ProductCollections = new HashSet<ProductCollection>();
            this.ProductImages = new HashSet<ProductImage>();
            this.Listings = new HashSet<Listing>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public string Colorway { get; set; }

        public int? Quantity { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        public ICollection<ProductCollection> ProductCollections { get; set; }

        public ICollection<Listing> Listings { get; set; }

   

    }
}
