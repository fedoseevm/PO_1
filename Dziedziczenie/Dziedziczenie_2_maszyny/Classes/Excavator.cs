using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_2_maszyny.Classes
{
    internal class Excavator : Machine
    {
        // Konstruktor łańcuchowy
        public Excavator(string name, MachineType type) : base(name, type) { }

        // Konstruktor kopiujący
        public Excavator(Excavator excavator) : base(excavator)
        {

        }
        // Destruktor
        ~Excavator()
        {
            Console.WriteLine($"Koparka {Name} została zniszczona");
        }
        // Przesłonięcie metody wirtualnej Start()
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna kopanie");
        }

        // Przeciążenie metody Stop()
        public void Stop(string reason)
        {
            Console.Write($"{Name} została zatrzymana z powodu: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(reason);
            Console.ResetColor();
        }
        public void Dig()
        {
            Console.WriteLine($"{Name} kopie");
        }

        // Przesłonięcie metody Work()
        public override void Work()
        {
            Dig();
        }
    }
}
