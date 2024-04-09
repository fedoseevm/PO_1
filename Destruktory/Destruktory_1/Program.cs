using Destruktory_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destruktory_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ferrari", 300);
            Car car2 = new Car("Porche", 280);
            Car car3 = new Car("Lamborgini", 320);

            car1.StartRace();
            car2.StartRace();
            car3.StartRace();

            car2 = null;
            Console.ReadKey();
            Console.WriteLine("123");

            Console.ReadKey();
        }
    }
}
