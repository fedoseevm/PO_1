using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory_1.Classes
{
    internal class Person
    {
        // Publiczne statyczne pole, które przechowuje liczbę obiektów klasy Person
        public static int Counter = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }

        // Konstruktor statyczny, jest wywoływany automatycznie, aby zainicjować klasę przed utworzeniem perwszej instancji. Jest wywoływany tylko 1 raz, przep pierwszym użyciem typu. Konstruktor statyczny nie może mieć paramentrów ani modyfikatorów dostępu. Służy do inicjowania pól statycznych luv wykonywania innych operacji statycznych. 
        static Person()
        {
            Console.WriteLine("Statyczny konstruktor klasy person \n");
            Counter++;
        }

        // Konstruktor domyślny jest bezparametrowym. Jeśli klasa nie ma żadnego konstruktora, to konstruktor domyślny jest wywoływany przy tworzeniu obiektu. Inicjuje on wszystkie pola do ich watrości domyślnych. Jeśli zdefiniujemy jakiś konstruktor paramentryczny, to nie otrzymamy automatycznie konstruktora domyślnego i musimy go samodzielnie zadeklarować.

        // Dodać konstuktor domyślny
        public Person() 
        {
            Console.WriteLine("Kostruktor domyślny klasy Person\n");
            Name = "Nieznane";
            Surname = "Nieznane";
            // Counter++;
        }

        // Kostruktor parametryczny ma co najmniej 1 parametr. Słyży do inicjowania pól obiektu zgodnie z wartościami podanymi przy tworzeniu obiektu. Możemy mieć wiele konstruktorów parametrycznych, o ile różnią się liczbą lub typem paramemetrów.
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Counter++;
        }

        // Konstruktor paramentryczny z 1 parametrem
        public Person(string name)
        {
            Name = name;
            Counter++;
        }

        // Kostruktor parametryczny z 3 paramentrami
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Counter++;
        }

        // Konstruktor parametryczny z 4 paramentrami
        // this służy do wywołania innego konstruktora tej samej klasy, czyli konstruktora parametrycznego z 3 parametrami. Dzięki temu konstruktor z 4 parametrami nie musi inicjowaniać pól Name, Surname, Agem a może skupić się na dodaniu pola Height. Hest to sposób na uniknięcie powtarzanie kodu i zapewnienie spójności danych.
        public Person(string name, string surname, int age, float height) : this(name, surname, age)
        {
            Height = height;
        }

        public string GetData()
        {
            return $"Imię: {Name}, nazwisko: {Surname}, Wiek: {Age} \n";
        }

    }
}
