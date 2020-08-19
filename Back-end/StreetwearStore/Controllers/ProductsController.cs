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
        public async Task<ActionResult<ICollection<ProductsListViewModel>>> GetAll()
        {
            return this.productsService.GetProducts<ProductsListViewModel>().ToList();
        }
    }
}
