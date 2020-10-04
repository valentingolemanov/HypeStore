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
        public IActionResult Get()
        {
            var collections = this.collectionsService.GetCollections<CollectionsResponseDTO>();
            return this.Ok(collections);
        }


        [HttpPost]
        public async Task<IActionResult> Post(CollectionReqestDTO model)
        {

            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

            int productId;

            try
            {
                productId = await this.collectionsService
                .CreateAsync(model.Name,
                model.Description,
                model.ImageUrl,
                model.HomeDisplay,
                model.DisplayRows,
                model.DisplayCols,
                model.DisplayPositionIndex);
            }
            catch
            {
                return this.BadRequest();
            }

            return this.Ok(productId);

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

        public async Task<IActionResult> Put(CollectionReqestDTO dto)
        {
            try
            {
                await this.collectionsService.Update(dto.Id,
                    dto.Name,
                    dto.Description,
                    dto.ImageUrl,
                    dto.HomeDisplay,
                    dto.DisplayRows,
                    dto.DisplayCols,
                    dto.DisplayPositionIndex);
            }
            catch 
            {
                return this.BadRequest();
            }

            return this.Ok();
        }
    }
}
