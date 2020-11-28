using AutoMapper;
using StreetwearStore.Data.Entities;
using StreetwearStore.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetwearStore.Web.ViewModels.Products
{
    public class GetProductDTO : IMapFrom<Listing>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<string> ImagesUrl { get; set; }

        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public List<int> CollectionIds { get; set; }

        public string AddedOn { get; set; }

        public string LastModified { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Listing, GetProductDTO>()
                .ForMember(x => x.Title, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.BrandName, y => y.MapFrom(z => z.Brand.Name))
                .ForMember(x => x.AddedOn, y => y.MapFrom(z => z.CreatedOn.ToString("MMM dd, yyyy")))
                .ForMember(x => x.LastModified, y => y.MapFrom(z => z.ModifiedOn.ToString("MMM dd, yyyy")))
                .ForMember(x => x.CollectionIds, y => y.MapFrom(z => z.ProductCollections.Select(w => w.CollectionId)));
        }
    }
}
