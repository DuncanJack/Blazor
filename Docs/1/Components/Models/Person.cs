using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.Models
{
    public class Person
    {
        public string Name { get; set; }

        public void Test()
        {
            Console.WriteLine("Person.Test");
        }
    }
}
