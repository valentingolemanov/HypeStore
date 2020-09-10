namespace StreetwearStore.Web.ViewModels.Products
{
    using AutoMapper;
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Services.Mapping;

    public class ProductsListViewModel : IMapFrom<Product>, IHaveCustomMappings

    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string BrandName { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Product, ProductsListViewModel>()
                 .ForMember(x => x.Title, y => y.MapFrom(z => z.Name))
                 .ForMember(x => x.BrandName, y => y.MapFrom(z => z.Brand.Name));
        }
    }
}
