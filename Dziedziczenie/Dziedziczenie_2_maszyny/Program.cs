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
            simulator.Add(new Excavator("Excavator-200", MachineType.Excavator));
            simulator.Add(new Crane("Crane-200", MachineType.Crane));
            simulator.Add(new Bulldozer("Bulldozer-200", MachineType.Bulldozer));
            simulator.Add(new Loader("Loader-200", MachineType.Loader));
            Console.WriteLine("");
            simulator.StartAll();

            Console.WriteLine();
            simulator.WorkAll();

            Console.WriteLine();
            simulator.StopAll();

            Console.WriteLine("\nNaciśnij dowolny przycisk, aby zakończyć program.");
            Console.ReadKey();
        }
    }
}
