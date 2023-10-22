using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* PROSTA WERSJA
            Console.Write("Podaj bok a: ");
            double a;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(a);
             }
             else   
                Console.WriteLine("Błędne dane podane przez użytkownika");
            */

            // WERSJA PRAWIDLOWA
            bool isCorrect = false;
            do
            {
                Console.Write("Podaj bok a: ");
                double a;
                while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.WriteLine("Podaj poprawne dane");
                    Console.Write("Podaj bok a: ");
                }

                Console.Write("Podaj bok b: ");
                double b;
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine("Podaj poprawne dane");
                    Console.Write("Podaj bok b: ");
                }

                Console.Write("Podaj bok c: ");
                double c;
                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.WriteLine("Podaj poprawne dane");
                    Console.Write("Podaj bok c: ");
                }

                if (IsTriangle(a, b, c))
                {
                    isCorrect = true;
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    double area = CalculateTriangleArea(a, b, c);
                    Console.WriteLine("Pole trójkąta o bokach {0}, {1}, {2} wynosi: {3:F4}cm\x00B2", a, b, c, area);
                    // <zmienna>:F4 - ogranicza do 4 liczb po ','
                    Console.OutputEncoding = System.Text.Encoding.Default;

                }
                else
                {
                    Console.WriteLine("Podane długości boków nie tworzą trókąta");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            } while (!isCorrect);
        }
        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;     // zwraca TRUE, jeśli warunki się spełniają; FALSE jeśli nie
        }

        static double CalculateTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
