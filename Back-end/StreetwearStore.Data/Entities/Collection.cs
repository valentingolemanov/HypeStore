using StreetwearStore.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreetwearStore.Data.Entities
{
    public class Collection : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
