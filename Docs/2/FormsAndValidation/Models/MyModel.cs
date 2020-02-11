using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndValidation.Models
{
    public class MyModel
    {
        [Required]
        public string Identifier { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Name is too long (maximum 10 characters)")]
        public string Name { get; set; }
    }
}