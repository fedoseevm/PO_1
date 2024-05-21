using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_2_maszyny.Classes
{
    internal class Machine
    {
        public string Name { get; set; }
        // Konstruktor główny
        public Machine(string name)
        {
            Name = name;
            Console.WriteLine($"{Name} została stworzona");
        }
        // Konstruktor kopiujący
        public Machine(Machine machine)
        {
            Name = machine.Name;
            Console.WriteLine($"Kopia maszyny {Name} została stworzona");
        }
        ~Machine()
        {
            Console.WriteLine($"{Name} została zniszczona");
        }

        // virtual pozwala na zmianę tej metody w pochodnej klasie
        public virtual void Start()
        {
            Console.WriteLine($"{Name} została uruchomiona");
        }
        public void Stop()
        {
            Console.WriteLine($"{Name} została zatrzymana");
        }
        public virtual void Work()
        {
            Console.WriteLine($"{Name} pracuje");
        }
    }
}
