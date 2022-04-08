using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey_Validation.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Dojo Location is required")]
        public string DojoLocation { get; set; }


        [Required(ErrorMessage = "Favorite Language is required")]
        public string FavLang { get; set; }


        [MinLength(20, ErrorMessage = "Comment must be at least 20 characters")]
        public string Comment { get; set; }
    }
}