namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;
    using StreetwearStore.Data.Entities.Enums;

    public class Listing : BaseModel<int>
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int SizeId { get; set; }

        public Size Size { get; set; }

        public Condition Condition { get; set; }

        public decimal Price { get; set; }
    }
}
