namespace StreetwearStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StreetwearStore.Services.Products;
    using StreetwearStore.Web.ViewModels.Products;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ProductsController : Controller
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
                productId = await this.productsService.CreateAsync(model.Title, model.Description, model.ImageUrl, model.Price);
            }

            if(productId == -1)
            {
                return this.BadRequest();
            }
            else
            {
                return this.Json(productId);
            }
        }

        [HttpGet]
        [Route("details")]
        public IActionResult Details(int id)
        {
            var product = this.productsService.GetById<DetailsViewModel>(id);

            if(product == null)
            {
                return this.NotFound();
            }

            return this.Json(product);
        }
    }
}
