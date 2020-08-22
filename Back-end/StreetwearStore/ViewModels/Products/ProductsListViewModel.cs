namespace StreetwearStore.Web.ViewModels.Products
{
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Services.Mapping;

    public class ProductsListViewModel : IMapFrom<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
