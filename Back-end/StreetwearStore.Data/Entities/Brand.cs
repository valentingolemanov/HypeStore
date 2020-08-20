using StreetwearStore.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreetwearStore.Data.Entities
{
    public class Brand : BaseDeletableModel<int>
    {
        public Brand()
        {
            this.Products = new HashSet<Product>();
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
