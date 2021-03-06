using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace Wedding.Models
{
    public class User
    {
        [Key] public int UserId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [MinLength(2, ErrorMessage = "*Needs to be at least 2 characters")]
        [Display(Name = "First Name", Prompt = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*Required")]
        [MinLength(2, ErrorMessage = "*Needs to be at least 2 characters")]
        [Display(Name = "Last Name", Prompt = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*Required")]
        [EmailAddress]
        [Display(Name = "Email", Prompt = "Email")]
        public string Email { get; set; }

        public string ImageProfile { get; set; }

        [Required(ErrorMessage = "*Required")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password", Prompt = "Password")]

        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "*Required")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password", Prompt = "Confirm Password")]
        public string Confirm { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
        // Relationship

        // One-to-Many with Weddings
        public List<WeddingModel> WeddingsPlans { get; set; }

        // Many-to-Many with Guests
        public List<Guest> Atteding { get; set; }

    }
}