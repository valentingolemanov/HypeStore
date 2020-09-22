using StreetwearStore.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreetwearStore.Data.Entities
{
    public class ProductImage : BaseDeletableModel<int>
    {
        public string Path { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
