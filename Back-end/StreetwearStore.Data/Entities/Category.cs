namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;

    using System.Collections.Generic;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Listings = new HashSet<Listing>();
          
        }

        public string Name { get; set; }
        

        public string Description { get; set; }
        
        public string ImageUrl { get; set; }

        public ICollection<Listing> Listings { get; set; }
    }
}
