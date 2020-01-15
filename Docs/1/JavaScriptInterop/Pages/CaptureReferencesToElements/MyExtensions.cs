using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavaScriptInterop.Pages.CaptureReferencesToElements
{
    public static class MyExtensions
    {
        public static async Task Focus(this ElementReference elementRef, IJSRuntime jsRuntime)
        {
            await jsRuntime.InvokeVoidAsync("captureReferencesToElements.focusElement", elementRef);
        }
    }
}
