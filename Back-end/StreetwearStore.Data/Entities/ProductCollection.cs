﻿namespace StreetwearStore.Data.Entities
{
    using StreetwearStore.Data.Common;

    public class ProductCollection 
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CollectionId { get; set; }

        public Collection Collection { get; set; }
    }
}
