using Microsoft.EntityFrameworkCore.Diagnostics;
using StreetwearStore.Data.Entities;
using StreetwearStore.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetwearStore.Web.ViewModels.Brands
{
    public class GetBrandsResponseModel : IMapFrom<Brand>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
