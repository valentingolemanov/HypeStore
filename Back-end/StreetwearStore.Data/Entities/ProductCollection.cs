﻿namespace StreetwearStore.Data.Entities
{
    public class ProductCollection
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CollectionId { get; set; }

        public Collection Collection { get; set; }
    }
}
