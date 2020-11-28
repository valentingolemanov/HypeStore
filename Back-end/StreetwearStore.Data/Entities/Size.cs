namespace StreetwearStore.Data.Entities
{
    
    using StreetwearStore.Data.Common;
    using StreetwearStore.Data.Entities.Enums;

    public class Size : BaseDeletableModel<int>
    {
        public Size()
        {
           
        }

        public double EU { get; set; }

        public double UK { get; set; }

        public double US { get; set; }

        public double CM { get; set; }

        public double Inches { get; set; }

        public Gender Gender { get; set; }

        public ClothSize ClothSize { get; set; }

       

    }
}
