namespace StreetwearStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StreetwearStore.Services.Products;
    using StreetwearStore.Web.DTOs.Products;
    using StreetwearStore.Web.ViewModels.Products;

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
            return this.Ok(this.productsService.GetProducts<GetProductDTO>());
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductDTO model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }
   
            int productId;
            var imageUrls = model.ImagesUrl.Select(x => x.Url).ToList();

            try
            {
                productId = await this.productsService.CreateAsync(model.Title, model.Description, imageUrls, model.BrandId, model.CollectionIds);
            }
            catch
            {
                return this.BadRequest();
            }

          
            return this.Ok(productId);
            
        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductRequestDTO dto)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            await this.productsService.Update(dto.Id,
                dto.Title,
                dto.Description,
                dto.ImagesUrl,
                dto.BrandId,
                dto.CollectionIds);

            return this.Ok();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            var product = this.productsService.GetById<GetProductDTO>(id);

            if(product == null)
            {
                return this.NotFound();
            }

            return this.Ok(product);
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
