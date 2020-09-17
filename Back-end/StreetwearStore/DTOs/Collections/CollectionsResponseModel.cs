namespace StreetwearStore.Web.ViewModels.Collections
{
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Services.Mapping;

    public class CollectionsResponseModel : IMapFrom<Collection>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
