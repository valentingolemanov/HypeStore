namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;
    using StreetwearStore.Data.Entities.Enums;
    using System.Collections.Generic;


    public class Product : BaseDeletableModel<int>
    {
        public Product()
        {
            this.ProductCollections = new HashSet<ProductCollection>();
            this.ProductImages = new HashSet<ProductImage>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int? SizeId { get; set; }

        public Size Size { get; set; }

        public string Color { get; set; }

        public Condition Condition { get; set; }

        public int? Quantity { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        public ICollection<ProductCollection> ProductCollections { get; set; }

    }
}
