﻿using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace prodcat.Models
{
    public class ProductCategory
    {
        [Key] 
        public int ProductCategoryId { get; set; }
        
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
        

    }
}