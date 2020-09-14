namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;
    using System.Collections.Generic;

    public class Collection : BaseDeletableModel<int>
    {
        public Collection()
        {
            this.CollectionProducts = new HashSet<ProductCollection>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<ProductCollection> CollectionProducts { get; set; }
    }
}
