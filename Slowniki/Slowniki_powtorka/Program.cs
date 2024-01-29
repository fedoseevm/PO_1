using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slowniki_powtorka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(1, "Anna");
            names.Add(2, "Ben");
            names.Add(3, "Chloe");
            foreach (var name in names)
                Console.WriteLine(name.Key + ": " + name.Value);

            foreach (int key in names.Keys)
            {
                Console.Write(key + " ");
                Console.WriteLine(names[key]);
            }

            foreach (string name in names.Values)
                Console.WriteLine(name);

            foreach (KeyValuePair<int, string> pair in names)
                Console.WriteLine($"{pair.Key}: {pair.Value}");


        }
    }
}
