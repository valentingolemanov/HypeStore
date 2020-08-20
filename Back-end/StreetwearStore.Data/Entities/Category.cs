namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;

    using System.Collections.Generic;

    public class Category : BaseModel<int>
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
