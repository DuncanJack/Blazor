using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.Pages.BaseClassInheritance
{
    public class BlazorRocksBase : ComponentBase
    {
        public string MyText { get; set; } = "This is my text ;)";
    }
}
