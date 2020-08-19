namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;
    using StreetwearStore.Data.Entities.Enums;
    using System;

    public class Product : BaseDeletableModel<string>
    {
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public  Gender Gender{ get; set; }

        public string CategoryId { get; set; }

        public Category Category { get; set; }


    }
}
