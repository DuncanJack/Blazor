using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavaScriptInterop.Pages.UseOfIJSRuntime
{
    public class MyClass
    {
        private readonly IJSRuntime _jSRuntime;

        public MyClass(IJSRuntime jsRuntime)
        {
            _jSRuntime = jsRuntime;
        }

        public void Log(string message)
        {
            _jSRuntime.InvokeVoidAsync("console.log", message);
        }
    }
}