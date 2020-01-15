using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FormsAndValidation.Shared.ValidationSupport
{
    public class PhoneNumber
    {
        public string Description { get; set; }

        [Required]
        public string Number { get; set; }
    }
}
