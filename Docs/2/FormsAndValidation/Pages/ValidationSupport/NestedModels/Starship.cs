using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndValidation.Pages.ValidationSupport.NestedModels
{
    public class Starship
    {
        [ValidateComplexType]
        public ShipDescription ShipDescription { get; set; }
    }
}