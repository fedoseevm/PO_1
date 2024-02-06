using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory_1.Classes
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string name, string lastname)
        {
            FirstName = name;
            LastName = lastname;
        }
    }
}
