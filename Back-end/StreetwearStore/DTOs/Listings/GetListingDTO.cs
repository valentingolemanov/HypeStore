
namespace StreetwearStore.Web.DTOs.Listings
{
    using AutoMapper;
    using Microsoft.Extensions.Configuration;
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Services.Mapping;
    using StreetwearStore.Web.ViewModels.Products;

    public class GetListingDTO : IMapFrom<Listing>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public GetProductDTO Product { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {

        }
    }
}
