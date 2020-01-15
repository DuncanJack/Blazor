using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FormsAndValidation.Shared.ValidationSupport
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        [ValidateComplexType]
        public Address Address { get; set; } = new Address();

        [ValidateComplexType]
        public PhoneNumber[] PhoneNumbers { get; set; } = new[]
        {
            new PhoneNumber(),
            new PhoneNumber()
        };
    }
}
