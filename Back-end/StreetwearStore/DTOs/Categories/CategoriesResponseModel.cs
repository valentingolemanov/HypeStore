﻿using StreetwearStore.Data.Entities;
using StreetwearStore.Services.Mapping;


namespace StreetwearStore.Web.DTOs.Categories
{
    public class CategoriesResponseModel : IMapTo<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
