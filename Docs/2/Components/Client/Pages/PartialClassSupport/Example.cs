using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.Client.Pages.PartialClassSupport
{
    public partial class Example
    {
        private string _message = string.Empty;

        private void OnClick()
        {
            _message = "OnClick";
        }
    }
}
