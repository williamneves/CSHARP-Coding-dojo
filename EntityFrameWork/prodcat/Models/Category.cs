using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace prodcat.Models
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }
        
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Name", Prompt = "Category Name")]
        public string Name { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Many to Many relationship
        public List<ProductCategory> ProductsIn { get; set; }
        
    }
}