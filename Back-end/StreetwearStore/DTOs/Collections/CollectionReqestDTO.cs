namespace StreetwearStore.Web.ViewModels.Collections
{
    using System.ComponentModel.DataAnnotations;


    public class CollectionReqestDTO
        
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Collection name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Image is required.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Home display option is required.")]
        public bool HomeDisplay { get; set; }

        public int DisplayRows { get; set; }

        public int DisplayCols { get; set; }

        public int DisplayPositionIndex { get; set; }
    }
}
