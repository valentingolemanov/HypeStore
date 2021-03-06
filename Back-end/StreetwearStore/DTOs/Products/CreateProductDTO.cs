﻿namespace StreetwearStore.Web.ViewModels.Products
{
    using StreetwearStore.Web.DTOs;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateProductDTO
    {
        [Required(ErrorMessage = "Product title is required.")]
        [MinLength(5, ErrorMessage = "Product title must be at least 5 characters.")]
        [MaxLength(100, ErrorMessage = "Product title must be at most 50 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Product description is required.")]
        [MinLength(40, ErrorMessage = "Product description must be at least 40 characters.")]
        [MaxLength(1000, ErrorMessage = "Product description must be at most 400 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Product brand is required.")]
        public int BrandId { get; set; }

        public List<int> CollectionIds { get; set; }

        [Required(ErrorMessage = "Product images are required.")]
        public List<ImageDTO> ImagesUrl { get; set; }


    }
}
