using Microsoft.AspNetCore.Http;


namespace StreetwearStore.Web.ViewModels.Products
{
    public class CreateInputViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
