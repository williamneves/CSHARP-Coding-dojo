using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace prodcat.Models
{
    public class Product
    {
        [Key] 
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Name", Prompt = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Description", Prompt = "Product Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Price", Prompt = "Product Price")]
        public double Price { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Many to Many relationship
        public List<ProductCategory> CategoriesIn { get; set; }
        

    }
}