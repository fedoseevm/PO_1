using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory_2.Classes
{
    // Definicja typu Enum Kind (Rodzaj)
    enum Kind
    {
        Ptak,
        Ryba,
        Gad,
        Plaz,
        Ssak
    }
    // Gad - reptile
    // Płaz - amphibian
    // Ssak - mammal

    internal class Animal
    {
        // Właściwości
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMammal { get; set; }
        public Kind Kind { get; set; }

        public Animal(string name)
        {
            Name = name;
            BirthDate = DateTime.MinValue;  // Ustawienie domyślnej daty urodzenia
            IsMammal = true;    // Ustawienie domyślnej wartości
            Kind = Kind.Ssak;   // Ustawienie domyślnego rodzaju
        }

        public Animal(string name, DateTime birthDate) : this(name)
        {
            BirthDate = birthDate;
        }

        public Animal(string name, DateTime birthDate, bool isMammal) : this(name, birthDate)
        {
            IsMammal = isMammal;
        }

        public Animal(string name, DateTime birthDate, bool isMammal, Kind kind) : this(name, birthDate, isMammal)
        {
            Kind = kind;
        }

        // Metoda opisująca zwierzę
        public string Describe()
        {
            string description = $"To jest {Name} \nData urodzenia: {BirthDate.ToShortDateString()}"; 
            if (IsMammal)
            {
                description += "\nZwierze jest ssakiem.";
            }
            else
            {
                description += $"\nZwierze nie jest ssakiem. \nRodzaj: {Kind}";
            }
            return description; 
        }

        public void ShowAge()
        {
            // Obliczenie wieku zwierzęcia w latach
            int age = DateTime.Now.Year;
            age -= BirthDate.Year;
            Console.Write($"Wiek {Name} wynosi: {age} ");
            if (age % 10 == 1)
                Console.Write("rok.\n\n");
            else if (age % 10 > 1 && age % 10 < 5)
                Console.Write("lata.\n\n");
            else
                Console.WriteLine("lat.\n\n");
        }
    }
}
