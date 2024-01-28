using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_1.Classes
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Adress Adress { get; set; }

        public void SetFirstName(string firstname)
        {
            FirstName = firstname;
        }
    }
}
