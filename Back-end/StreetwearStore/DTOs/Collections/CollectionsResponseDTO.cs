namespace StreetwearStore.Web.ViewModels.Collections
{
    using AutoMapper;
    using StreetwearStore.Data.Entities;
    using StreetwearStore.Services.Mapping;
    using StreetwearStore.Web.ViewModels.Products;
    using System.Collections.Generic;
    using System.Globalization;

    public class CollectionsResponseDTO : IMapFrom<Collection>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string CreatedOn { get; set; }

        public string LastModified { get; set; }

        public bool HomeDisplay { get; set; }

        public int DisplayRows { get; set; }

        public int DisplayCols { get; set; }

        public int DisplayPositionIndex { get; set; }

        public List<GetProductDTO> Products{ get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Collection, CollectionsResponseDTO>()
                .ForMember(x => x.CreatedOn, y => y.MapFrom(z => z.CreatedOn.ToString("g", CultureInfo.InvariantCulture)))
                .ForMember(x => x.LastModified, y => y.MapFrom(z => z.ModifiedOn.ToString("g", CultureInfo.InvariantCulture)));
        }
    }
}
