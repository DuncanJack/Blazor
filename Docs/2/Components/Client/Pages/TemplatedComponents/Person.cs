using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.Client.Pages.TemplatedComponents
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

        public List<Person> All => new List<Person>
        {
            new Person{ PersonId=1, Name="Person1"},
            new Person{ PersonId=2, Name="Person2"},
            new Person{ PersonId=3, Name="Person3"},
            new Person{ PersonId=4, Name="Person4"},
            new Person{ PersonId=5, Name="Person5"}
        };
    }
}