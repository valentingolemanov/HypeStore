namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;
    using StreetwearStore.Data.Entities.Enums;

    public class Product : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public Gender Gender{ get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public string Color { get; set; }

        public int? Quantity { get; set; }

        public USSize USSize { get; set; }

        public UKSize UKSize { get; set; }

        public EUSize EUSize { get; set; }

    }
}
