using StreetwearStore.Data.Common;
using StreetwearStore.Data.Entities;
using StreetwearStore.Data.Repository;
using StreetwearStore.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetwearStore.Services.Brands
{
    public class BrandsService : IBrandsService
    {
        private IDeletableEntityRepository<Brand> repository;
        public BrandsService(IDeletableEntityRepository<Brand> repository)
        {
            this.repository = repository;
        }

        public ICollection<TModel> GetBrands<TModel>()
        {
            return this.repository.All()
                .To<TModel>()
                .ToList();
        }
    }
}
