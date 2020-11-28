namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;
    using System.Collections.Generic;

    public class Collection : BaseDeletableModel<int>
    {
        public Collection()
        {
            this.CollectionProducts = new HashSet<ListingsCollections>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool HomeDisplay { get; set; }

        public int DisplayRows { get; set; }

        public int DisplayCols { get; set; }

        public int DisplayPositionIndex { get; set; }

        public ICollection<ListingsCollections> CollectionProducts { get; set; }
    }
}
