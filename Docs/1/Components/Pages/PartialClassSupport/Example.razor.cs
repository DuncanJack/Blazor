using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.Pages.PartialClassSupport
{
    public partial class Example
    {
        int currentCount = 0;

        void IncrementCount()
        {
            currentCount++;
        }
    }
}
