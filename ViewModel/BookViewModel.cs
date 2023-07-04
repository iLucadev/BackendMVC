using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.ViewModel
{
    public class BookViewModel
    {
        [Required(ErrorMessage = "Title field is required.")]
        [StringLength(50, ErrorMessage = "The field must be 50 characters maximum.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description field is required.")]
        [StringLength(250, ErrorMessage = "The field must be 250 characters maximum.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "ISBN field is required.")]
        [RegularExpression(@"^(?:ISBN(?:-13)?:?\ )?(?=[0-9]{13}$|(?=(?:[0-9]+[-\ ]){4})[-\ 0-9]{17}$)97[89][-\ ]?[0-9]{1,5}[-\ ]?[0-9]+[-\ ]?[0-9]+[-\ ]?[0-9]$",
        ErrorMessage = "Insert a valid ISBN.")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Year field is required.")]
        [RegularExpression(@"^(19|20)\d{2}$", ErrorMessage = "Insert a valid publish year.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "You must choose a cover image.")]
        public IFormFile Cover { get; set; }
    }
}