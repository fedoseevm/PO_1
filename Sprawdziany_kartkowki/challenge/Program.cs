using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisz program, który obliczy pole prostokąta
            bool isCorrect = false;
            do
            {
                try
                {
                    Console.Write("\nPodaj bok prostokąta a: ");
                    double a = double.Parse(Console.ReadLine());
                    while (a <= 0)
                    {
                        Console.WriteLine("Bok ma mieć wartość dodatnią");
                        Console.Write("\nPodaj bok prostokąta a: ");
                        a = double.Parse(Console.ReadLine());
                    }

                    Console.Write("\nPodaj bok prostokąta b: ");
                    double b = double.Parse(Console.ReadLine());
                    while (a <= 0)
                    {
                        Console.WriteLine("Bok ma mieć wartość dodatnią");
                        Console.Write("\nPodaj bok prostokąta b: ");
                        a = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine($"Pole prostokąta o bokach {a} i {b} = {(a * b):F4}");

                    isCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nNieprawidłowy format\n");
                }
                
                catch (OverflowException)
                {
                    Console.WriteLine($"\nwartość jest poza zakresem <{double.MinValue};{double.MaxValue}>\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n{ex.Message}\n");
                }
            } while (!isCorrect);
        }
    }
}
