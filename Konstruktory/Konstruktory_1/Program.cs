using Konstruktory_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person nowak = new Person("Bartosz");
            Person person1 = new Person();
            Person person2 = new Person("Paweł", "Kowal");
            Person person3 = new Person("Anna", "Lowak", 35);
            Person person4 = new Person("Krystyna", "Pawłak", 20, 190);

            // Wyświetlenie wartości pól obiektów
            Console.WriteLine("Obiekt nowak: {0}, {1}, {2}", nowak.Name, nowak.Surname, nowak.Age);
            Console.WriteLine("Obiekt person1: {0}, {1}, {2}", person1.Name, person1.Surname, person1.Age);
            Console.WriteLine("Obiekt person2: {0}, {1}, {2}", person2.Name, person2.Surname, person2.Age);
            Console.WriteLine("Obiekt person3: {0}, {1}, {2}", person3.Name, person3.Surname, person3.Age);
            Console.WriteLine("Obiekt person4: {0}, {1}, {2}, wzrost: {3}", person4.Name, person4.Surname, person4.Age, person4.Height);

            // Wyświetlenie liczby obiektów klasy Person
            Console.WriteLine("\nWyświetlenie liczby obiektów klasy Person: {0}", Person.Counter);

            //// Pobranie typu klasy Person
            //Type personType = typeof(Person);
            //Console.WriteLine(personType); // Konstruktory_1.Classes.Person

            //// Pobranie tablicy obiektów typu Person 
            //object[] personArray = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).Where(t => t == personType).
        }
    }
}
