using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ChefsDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        //Dish Name
        [Required(ErrorMessage = "*Required")]
        [MinLength(2, ErrorMessage = "*Needs to be at least 2 characters")]
        [Display(Name = "Name", Prompt = "Name")]
        public string Name { get; set; }

        //Dish Description
        [Required(ErrorMessage = "*Required")]
        [MinLength(2, ErrorMessage = "*Needs to be at least 2 characters")]
        [Display(Name = "Description", Prompt = "Description")]
        public string Description { get; set; }

        //Dish Tastiness
        [Required(ErrorMessage = "*Required")]
        [Range(1, 5, ErrorMessage = "Select a number between 1 and 5")]
        [Display(Name = "Tastiness", Prompt = "Select a Tastiness")]
        public int Tastiness { get; set; }

        //Dish Calories
        [Required(ErrorMessage = "*Required")]
        [Range(1, int.MaxValue, ErrorMessage = "*Needs to greater than 0")]
        [Display(Name = "Calories", Prompt = "Calories")]
        public int Calories { get; set; }

        //Dish Chef
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Chef", Prompt = "Select a Chef")]
        public int ChefId { get; set; }
        public Chef DishChef { get; set; }


    }
}