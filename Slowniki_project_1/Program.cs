using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slowniki_project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> slownik = new Dictionary<int, string>();
            slownik.Add(1, "Franek");
            slownik.Add(2, "Anna");
            slownik.Add(3, "Tomasz");

            foreach (string key in slownik.Values) // var key in slownik
            {
                Console.WriteLine(key); // key.Value
            }
            Console.WriteLine();

            // Tworzymy słownik, który przechowuje łańcuchy jako klucze i liczby jako wartości
            Dictionary<string, int> slownik1 = new Dictionary<string, int>();

            // Dodajemy kilka par klucz-wartość do słownika
            slownik1.Add("jeden", 1);
            slownik1.Add("dwa", 2);
            slownik1.Add("trzy", 3);

            // Wyświetlenie zawartości słownika za pomocą pętly foreach
            foreach (KeyValuePair<string, int> pair in slownik1)    // Zamiast KeyValuePair<string, int> można użyć var
            {
                Console.WriteLine("Klucz: {0}, wartość: {1}", pair.Key, pair.Value);
            }

        }
    }
}
