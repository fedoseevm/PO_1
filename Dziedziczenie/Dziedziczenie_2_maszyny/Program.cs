using Dziedziczenie_2_maszyny.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_2_maszyny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Machine excavator = new Excavator("Excavator E-100", MachineType.Excavator);
            excavator.Start();
            excavator.Work();

            ((Excavator)excavator).Stop("Awaria silnika");
            excavator.Stop();

            MachineSimulator simulator = new MachineSimulator();
            simulator.Add(new Excavator("E-200", MachineType.Excavator));
            simulator.Add(new Crane("E-200", MachineType.Crane));
            simulator.Add(new Bulldozer("E-200", MachineType.Bulldozer));
            simulator.Add(new Loader("E-200", MachineType.Loader));

            Console.WriteLine("\nNaciśnij dowolny przycisk, aby zakończyć program.");
            Console.ReadKey();
        }
    }
}
