using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class Counter : ICounter
    {
        private readonly IMyOtherService _myOtherService;

        private int _count = 0;

        public Counter(IMyOtherService myOtherService)
        {
            Console.WriteLine("Counter.Counter");
            _myOtherService = myOtherService;
        }

        public void Count()
        {
            _count++;
            Console.WriteLine($"Counter._count: {_count}");
        }
    }
}
