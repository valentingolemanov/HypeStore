namespace StreetwearStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StreetwearStore.Services.ListingImages;
    using StreetwearStore.Services.Products;
    using StreetwearStore.Web.DTOs.Listings;
    using StreetwearStore.Web.DTOs.Products;
    using StreetwearStore.Web.ViewModels.Products;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;


    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ListingsController : BaseController
    {
        private readonly IListingsService listingsService;
        private readonly IListingImageService listingImageService;

        public ListingsController(IListingsService listingsService, IListingImageService listingImageService)
        {
            this.listingsService = listingsService;
            this.listingImageService = listingImageService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(this.listingsService.GetProducts<GetProductDTO>());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm]CreateListingDTO model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

            try
            {
                int listingId = await this.listingsService.CreateAsync(model.Title, model.Description, model.BrandId);

                var files = Request.Form.Files;
                var folderName = Path.Combine("StaticFiles", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (files.Any(f => f.Length == 0))
                {
                    return BadRequest();
                }

                List<string> dbPaths = new List<string>();

                foreach (var file in files)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName); //you can add this path to a list and then return all dbPaths to the client if require
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

                await this.listingImageService.UploadImagesAsync(listingId, dbPaths);

                return this.Ok(listingId);

            }
            catch
            {
                return this.BadRequest();
            }


          

        }

        [HttpPut]
        public async Task<IActionResult> Put(EditProductRequestDTO dto)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            try
            {
                await this.listingsService.Update(dto.Id,
                    dto.Title,
                    dto.Description,
                    dto.ImagesUrl,
                    dto.BrandId,
                    dto.CollectionIds);
            }
            catch
            {
                return this.BadRequest();
            }

            return this.Ok();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            var product = this.listingsService.GetById<GetProductDTO>(id);

            if (product == null)
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
                await this.listingsService.Delete(id);
            }
            catch
            {
                return this.BadRequest();
            }

            return this.Ok();
        }
    }
}
