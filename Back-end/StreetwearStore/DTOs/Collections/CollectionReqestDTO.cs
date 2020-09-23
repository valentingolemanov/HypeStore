namespace StreetwearStore.Web.ViewModels.Collections
{
    using System.ComponentModel.DataAnnotations;


    public class CollectionReqestDTO
    {
        [Required(ErrorMessage ="Collection name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Image is required.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Home display option is required.")]
        public bool HomeDisplay { get; set; }

        public string DisplayRows { get; set; }

        public string DisplayCols { get; set; }

        public string DisplayPositionIndex { get; set; }
    }
}
