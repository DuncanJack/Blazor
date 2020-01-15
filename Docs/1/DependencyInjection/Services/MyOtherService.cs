using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class MyOtherService : IMyOtherService
    {
        public MyOtherService()
        {
            Console.WriteLine("MyOtherService.MyOtherService");
        }

        public void Log()
        {
            Console.WriteLine("MyOtherService.Log");
        }
    }
}
