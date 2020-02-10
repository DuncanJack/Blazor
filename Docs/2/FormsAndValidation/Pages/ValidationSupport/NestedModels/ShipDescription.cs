using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndValidation.Pages.ValidationSupport.NestedModels
{
    public class ShipDescription
    {
        [Required]
        [StringLength(40, ErrorMessage = "Description too long (40 char).")]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(240, ErrorMessage = "Description too long (240 char).")]
        public string LongDescription { get; set; }
    }
}