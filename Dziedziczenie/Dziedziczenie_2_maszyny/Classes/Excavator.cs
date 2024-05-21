using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_2_maszyny.Classes
{
    internal class Excavator : Machine
    {
        public Excavator(string name) : base(name) { }
        // Przesłonięcie metody wirtualnej
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna kopanie");
        }

        // Przeciążenie metody Stop
        public void Stop(string reason)
        {
            Console.Write($"{Name} została zatrzymana z powodu: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(reason);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
