using DependencyInjection.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Pages.PartialClassesExamples
{
    public partial class Example
    {
        [Inject]
        public ICounter Counter { get; set; }
    }
}