using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_1.Classes
{
    enum Gender // nowy typ danych
    {
        mężczyzna,
        kobieta
    }
    enum Permission
    {
        Administrator = 1,
        Moderator = 2,
        User = 3,
        Guest = 4

    }

    internal class Person
    {
        public Gender Gender { get; set; }
        public Permission Permission { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Adress Adress { get; set; }

        public void SetFirstName(string firstname)
        {
            FirstName = firstname;
        }

        public void SetLastName(string lastname)
        {
            LastName = lastname;
        }

        public string GetData()
        {
            return $"\nImię i nazwisko: {FirstName} {LastName}, zwrost: {Height}cm, waga: {Weight}kg";
        }
    }
}
