namespace StreetwearStore.Data.Entities
{
    using System.Collections.Generic;

    using StreetwearStore.Data.Common;
    using StreetwearStore.Data.Entities.Enums;

    public class Size : BaseDeletableModel<int>
    {
        public Size()
        {
            this.Products = new HashSet<Product>();
        }

        public double EU { get; set; }

        public double UK { get; set; }

        public double US { get; set; }

        public double CM { get; set; }

        public double Inches { get; set; }

        public Gender Gender { get; set; }

        public ClothSize ClothSize { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
