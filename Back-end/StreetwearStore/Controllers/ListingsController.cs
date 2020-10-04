

namespace StreetwearStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StreetwearStore.Services.Listings;
    using StreetwearStore.Web.DTOs.Listings;
 
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly IListingsService listingsService;

        public ListingsController(IListingsService listingsService)
        {
            this.listingsService = listingsService;
        }

        // GET: api/<ListingController>
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(this.listingsService.GetListings<GetListingDTO>());
        }

        // GET api/<ListingController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var listing = this.listingsService.GetById<GetListingDTO>(id);

            if(listing == null)
            {
                return this.NotFound();
            }

            return this.Ok(listing);
        }

        // POST api/<ListingController>
        [HttpPost]
        public async Task<IActionResult> Post(CreateListingDTO dto)
        {
            int listingId;

            try
            {
                listingId = await this.listingsService.CreateAsync(dto.ProductId, dto.SizeId, dto.Condition, dto.Price);
               
            }
            catch
            {
                return this.BadRequest();
            }

            return this.Ok(listingId);
            
        }

        // PUT api/<ListingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ListingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
