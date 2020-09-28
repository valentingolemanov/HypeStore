using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreetwearStore.Data.Common;
using StreetwearStore.Data.Entities;
using StreetwearStore.Data.Repository;
using StreetwearStore.Services.Brands;
using StreetwearStore.Web.ViewModels.Brands;

namespace StreetwearStore.Web.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BrandsController : BaseController
    {
        private readonly IBrandsService brandsService;

        public BrandsController(IBrandsService brandsService)
        {
            this.brandsService = brandsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var brands = this.brandsService.GetBrands<BrandsResponseDTO>();

            return this.Ok(brands);
        }

    }
}
