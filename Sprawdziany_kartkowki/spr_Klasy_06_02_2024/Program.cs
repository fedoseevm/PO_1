using Fedoseev_Maksim.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedoseev_Maksim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GRUPA 1
            Car samochod = new Car();
            samochod.Brand = "Nissan";
            samochod.Model = "Skyline";
            samochod.Year = 2008;
            samochod.Price = 24700F;

            samochod.Owner = new Person();
            samochod.Owner.Name = "Jan";
            samochod.Owner.LastName = "Nowak";
            samochod.Owner.DateOfBirth = new DateTime(1998, 4, 29);
            samochod.Owner.children_names = new List<string> { "Adam", "Barbara", "Charlie" };

            Console.WriteLine(samochod.GetInfo());

            Console.Write($"\nPodaj kolor samochodu (white, black, red, green, blue): ");

            switch (Console.ReadLine().ToLower())
            {
                case ("red"):
                    samochod.Color = Color.red;
                    break;
                case ("white"):
                    samochod.Color = Color.white;
                    break;
                case ("black"):
                    samochod.Color = Color.black;
                    break;
                case ("blue"):
                    samochod.Color = Color.blue;
                    break;
                case ("green"):
                    samochod.Color = Color.green;
                    break;
                default:
                    Console.WriteLine("Są dostępne tylko 5 kolorów");
                    break;

            }

            Console.WriteLine("\n" + samochod.GetInfo() + "\n");
        }
    }
}
