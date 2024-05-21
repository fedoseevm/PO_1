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
            Machine excavator = new Excavator("Excavator E-100");
            excavator.Start();

            ((Excavator)excavator).Stop("Awaria silnika");
            excavator.Stop();

            Console.WriteLine("\nNaciśnij dowolny przycisk, aby zakończyć program.");
            Console.ReadKey();
        }
    }
}
