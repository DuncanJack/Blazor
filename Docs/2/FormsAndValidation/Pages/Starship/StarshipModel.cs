﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndValidation.Pages.Starship
{
    public class StarshipModel
    {
        [Required]
        [StringLength(16, ErrorMessage = "Identifier too long (16 character limit).")]
        public string Identifier { get; set; }

        public string Description { get; set; }

        [Required]
        public string Classification { get; set; }

        [Range(1, 100000, ErrorMessage = "Accommodation invalid (1-100000).")]
        public int MaximumAccommodation { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "This forms disallows unapproved ships.")]
        public bool IsValidatedDesign { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }
    }
}