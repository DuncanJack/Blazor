using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.Client.Pages.InvokeComponentMethods
{
    public class NotifierService
    {
        // Can be called from anywhere
        public async Task Update(string key, int value)
        {
            Console.WriteLine("NotifierService.Update");
            if(Notify != null)
            {
                await Notify.Invoke(key, value);
            }
        }

        public event Func<string, int, Task> Notify;
    }
}
