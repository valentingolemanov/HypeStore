namespace StreetwearStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StreetwearStore.Services.Collections;
    using StreetwearStore.Web.ViewModels.Collections;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CollectionsController : BaseController
    {
        private readonly ICollectionsService collectionsService;

        public CollectionsController(ICollectionsService collectionsService)
        {
            this.collectionsService = collectionsService;
        }

        [HttpGet]
        public IActionResult GetCollections()
        {
            var collections = this.collectionsService.GetCollections<CollectionsResponseModel>();
            return this.Json(collections);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CollectionReqestModel model)
        {
            var productId = -1;
            if (ModelState.IsValid)
            {
                productId = await this.collectionsService.CreateAsync(model.Name, model.Description, model.ImageUrl);
            }

            if (productId == -1)
            {
                return this.BadRequest();
            }
           
            return this.Json(productId);
            
        }
    }
}
