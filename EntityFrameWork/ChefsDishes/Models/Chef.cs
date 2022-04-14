using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ChefsDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }
        [Required(ErrorMessage = "*Required")]
        [MinLength(2, ErrorMessage = "*Needs to be at least 2 characters")]
        [Display(Name = "First Name", Prompt = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*Required")]
        [MinLength(2, ErrorMessage = "*Needs to be at least 2 characters")]
        [Display(Name = "Last Name", Prompt = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*Required")]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday", Prompt = "Birthday")]
        public DateTime Birthday { get; set; }

        public List<Dish> CreatedDishes { get; set; }

        public int get_age()  
            {  
            int age = 0;  
            age = DateTime.Now.AddYears(-this.Birthday.Year).Year;  
            return age;
        }  

    }
}