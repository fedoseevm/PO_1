using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destruktory_1.Classes
{
    internal class Car
    {
        private string name;
        private double speed;

        public Car(string name, double speed)
        {
            this.name = name;
            this.speed = speed;
        }

        // Destruktor służy do usunięcia obiektów klasy
        ~Car()
        {
            Console.WriteLine($"Samochód {name} został zniszczony.");
        }
        public void StartRace()
        {
            Console.WriteLine($"Samochód {name} rozpoczyna wyścig.");
        }
    }
}
