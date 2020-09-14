namespace StreetwearStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StreetwearStore.Services.Collections;
    using StreetwearStore.Web.ViewModels.Collections;

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
    }
}
