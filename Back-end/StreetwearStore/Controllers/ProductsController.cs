namespace StreetwearStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StreetwearStore.Services.Products;
    using StreetwearStore.Web.DTOs.Products;
    using StreetwearStore.Web.ViewModels.Products;
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
        public IActionResult Get()
        {
            return this.Json(this.productsService.GetProducts<ProductDetailsDTO>());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDTO model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

            var imageUrls = model.ImagesUrl.Select(x => x.Url).ToList();

            var productId = await this.productsService.CreateAsync(model.Title, model.Description, imageUrls, model.BrandId, model.CollectionIds);

            if (productId == 0)
            {
                return this.BadRequest();
            }
          
            return this.Json(productId);
            
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EditProductRequestDTO dto)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            var editedProductId = await this.productsService.EditAsync(dto.Id,
                dto.Title,
                dto.Description,
                dto.ImagesUrl,
                dto.BrandId,
                dto.CollectionIds);

            return this.Json(editedProductId);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            var product = this.productsService.GetById<ProductDetailsDTO>(id);

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
