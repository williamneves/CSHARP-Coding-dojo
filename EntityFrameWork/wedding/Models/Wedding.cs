using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wedding.Models
{
    
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }
        
        [Required]
        [Display(Name = "Wedder One", Prompt = "Wedder One")]
        public string WedderOne { get; set; }
        
        [Required]
        [Display(Name = "Wedder Two", Prompt = "Wedder Two")]
        public string WedderTwo { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        // [Range(typeof(DateTime), DateTime.Now.ToString(), DateTime.Now.AddYears(2).ToString())]
        [CustomDateRange]
        public DateTime Date { get; set; }
        
        [Required]
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
        public int UserId { get; set; }
        public User Creator { get; set; }
        
        //User lists
        public List<Guest> Guests { get; set; }

    }
}