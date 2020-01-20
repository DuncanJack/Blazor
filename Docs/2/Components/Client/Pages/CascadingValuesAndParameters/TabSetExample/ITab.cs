using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.Client.Pages.CascadingValuesAndParameters.TabSetExample
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
