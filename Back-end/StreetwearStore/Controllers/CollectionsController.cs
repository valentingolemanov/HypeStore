namespace StreetwearStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StreetwearStore.Services.Collections;
    using StreetwearStore.Web.ViewModels.Collections;
    using System;
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
            var collections = this.collectionsService.GetCollections<CollectionsResponseDTO>();
            return this.Json(collections);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CollectionReqestDTO model)
        {

            if (!ModelState.IsValid)
            {

                return this.BadRequest();
            }
            var productId = await this.collectionsService
                  .CreateAsync(model.Name,
                  model.Description,
                  model.ImageUrl,
                  model.HomeDisplay,
                  int.Parse(model.DisplayRows),
                  int.Parse(model.DisplayCols),
                  int.Parse(model.DisplayPositionIndex));

            if (productId == -1)
            {
                return this.BadRequest();
            }


            return this.Json(productId);

        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await this.collectionsService.Delete(id);
            }
            catch
            {
                return this.BadRequest();
            }

            return this.Ok();
        }
    }
}
