using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FormsAndValidation.Shared.ValidationSupport
{
    public class Address
    {
        public string Street { get; set; }

        [Required]
        public string City { get; set; }
    }
}
