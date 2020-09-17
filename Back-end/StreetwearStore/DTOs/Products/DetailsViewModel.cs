﻿using AutoMapper;
using StreetwearStore.Data.Entities;
using StreetwearStore.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetwearStore.Web.ViewModels.Products
{
    public class DetailsViewModel : IMapFrom<Product>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public string BrandName { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Product, DetailsViewModel>()
                .ForMember(x => x.Title, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.BrandName, y => y.MapFrom(z => z.Brand.Name));
        }
    }
}