using System;
using System.Collections.Generic;
using System.Text;

namespace StreetwearStore.Services.Brands
{
    public interface IBrandsService
    {
        ICollection<TModel> GetBrands<TModel>();
    }
}
