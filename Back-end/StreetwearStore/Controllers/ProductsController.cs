namespace StreetwearStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StreetwearStore.Services.Products;
    using StreetwearStore.Web.ViewModels.Products;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ProductsController : BaseController
    {
        private readonly IProductsService productsService; 

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return this.Json(this.productsService.GetProducts<ProductsListViewModel>());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateInputViewModel model)
        {
            var productId = -1;
            if (ModelState.IsValid)
            {
                productId = await this.productsService.CreateAsync(model.Title, model.Description, model.ImageUrl, model.Price, model.BrandId, model.CollectionIds);
            }

            if(productId == -1)
            {
                return this.BadRequest();
            }
          
                return this.Json(productId);
            
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Details(int id)
        {
            var product = this.productsService.GetById<DetailsViewModel>(id);

            if(product == null)
            {
                return this.NotFound();
            }

            return this.Json(product);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await this.productsService.Delete(id);
            }
            catch
            {
                return this.BadRequest();
            }

            return this.Ok();
        }
    }
}
