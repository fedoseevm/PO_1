using Konstruktory_2.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ZADANIE: Napisz program w języku C#, który będzie umożliwiał zarządzanie listą zwierząt. Program powinien spełniać następujące wymagania.

            // Każde zwierzę powinno mieć następujące właściwości: nazwę, datę urodzenia, informację czy jest ssakiem i rodzaj(ptak, ryba, gad, płaz lub ssak).
            // Program powinien umożliwiać dodawanie nowych zwierząt do listy, podając ich właściwości  od użytkownika.
            // Program powinien umożliwiać wyświetlanie listy zwierząt z ich numerami i nazwami.
            // Program powinien umożliwiać wyświetlanie szczegółów o wybranym zwierzęciu, takich jak  opis, wiek i rodzaj.
            // Program powinien umożliwiać usuwanie wszystkich lub pojedynczego zwierzęcia z listy.
            // Program powinien mieć menu główne z opcjami do wyboru przez użytkownika.
            // Program powinien być napisany zgodnie z konwencją nazewnictwa i formatowania kodu w C#.

            // Wskazówki:
            // Użyj klasy Animal do reprezentowania zwierzęcia i zdefiniuj jej właściwości, konstruktory  i metody.
            // Użyj typu wyliczeniowego Kind do reprezentowania rodzaju zwierzęcia i zdefiniuj jego wartości.
            // Użyj listy generycznej List<Animal> do przechowywania zwierząt i korzystaj z jej metod do dodawania, usuwania i wyświetlania elementów.
            // Użyj klasy Console i jej metod do komunikacji z użytkownikiem i obsługi wejścia i wyjścia.
            // Użyj instrukcji switch lub if do obsługi różnych opcji menu i wywoływania odpowiednich  metod.
            // Użyj klasy DateTime i jej metod do przechowywania i obliczania daty urodzenia i wieku zwierzęcia.

            Animal a = new Animal("Burek");
            a.BirthDate = new DateTime(2020, 1, 3);
            Console.WriteLine(a.Describe());
            a.ShowAge();

            Animal a2 = new Animal("Kot", new DateTime(2018, 1, 20));
            Console.WriteLine(a2.Describe());
            a2.ShowAge();

            Animal a3 = new Animal("Pies", new DateTime(2000, 4, 19), true);
            Console.WriteLine(a3.Describe());
            a3.ShowAge();

            Animal a4 = new Animal("Ara", new DateTime(2001, 10, 11), false, Kind.Ptak);
            Console.WriteLine(a4.Describe());
            a4.ShowAge();

            // Tworzenie listy zwierząt
            List<Animal> Animals = new List<Animal>();

            // Wyświetlenie menu głównego
            ShowMenu(Animals);
        }

        static void ShowMenu(List<Animal> animals)
        {
            // Wyczyszczenie konsoli
            Console.Clear();

            // Wyświetlenie opcji menu
            Console.WriteLine("Witaj w programie zarządzania zwierzętami");
            Console.WriteLine("Wybierz jedną z opcji: ");
            Console.WriteLine("1. Dodaj zwierzę");
            Console.WriteLine("2. Pokaż listę zwierząt");
            Console.WriteLine("3. Pokaż szczegóły zwierzęcia");
            Console.WriteLine("4. Usuń zwierzę");
            Console.WriteLine("5. Zakończ program");

            // Wczytanie wyboru użytkownika
            Console.Write("\nWybór: ");
            string choise = Console.ReadLine();
            Console.WriteLine();
            switch (choise)
            {
                case "1":
                    // Wywołanie metody dodającej zwierzę
                    AddNewAnimal(animals);
                    break;
                case "2":
                    // Wywołanie metody pokazującej listę zwierząt
                    ShowAnimalList(animals);
                    break;
                case "3":
                    // Wywołanie metody pokazującej szczegóły zwierzęcia
                    ShowAnimalDetails(animals);
                    break;
                case "4":
                    // Wywołanie metody usuwającej zwierzę
                    RemoveAnimal(animals);
                    break;
                case "5":
                    // Zakończenie programu
                    Console.WriteLine("Dziękujemy za korzystanie z programu");
                    return;
                default:
                    Console.WriteLine("Niepoprawna opcja. Naciśnij dowolny klawisz, aby spróbować ponownie");
                    Console.ReadKey();
                    ShowMenu(animals);
                    break;

            }
        }

        // Metoda usuwająca zwierze
        private static void RemoveAnimal(List<Animal> animals)
        {
            Console.Clear();

            // Sprawdzenie czy lista jest pusta
            if (animals.Count == 0)
            {
                // Wyświetlenie komunikatu o braku zwierząt
                Console.WriteLine("Nie dodano żadnych zwierząt.");
            }
            else
            {
                // Wyświetlenie podmenu z opcjami usuwania
                Console.WriteLine("\n1. Usuń wszystkie zwierzęta");
                Console.WriteLine("2. Usuń jedno zwierzę");
                Console.Write("\nWybierz jedną z opcji: ");

                // Wczytanie wyboru użytkownika
                string choice = Console.ReadLine();

                // Obsługa wyboru użytkownika
                switch (choice)
                {
                    case "1":
                        // Wyczyszczenie listy zwierząt
                        animals.Clear();

                        // Wyświetlenie potwierdzenia
                        if (animals.Count == 0)
                            Console.WriteLine("Usunięto wszystkie zwierzęta\n");
                        break;
                    case "2":
                        // Wyświetlenie listy zwierząt z numerami
                        for (int i = 0; i < animals.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ". " + animals[i].Name);
                        }
                        Console.Write("Podaj numer zwierzęcia, którego szczegóły chcesz usunąć: ");
                        int index = int.Parse(Console.ReadLine()) - 1;

                        // Sprawdzenie
                        if (index >= 0 && index < animals.Count)
                        {
                            // Usunięcie zwierzęta z listy
                            animals.RemoveAt(index);
                            Console.WriteLine("\nUsunięto zwierzę\n");
                        }
                        else
                        {
                            // Wyświetlenie komunikatu o błędzie
                            Console.WriteLine("Niepoprawny numer. Spróbuj ponownie.");
                        }
                        break;
                    default:
                        Console.WriteLine("Niepoprawna opcja. Spróbój ponownie");
                        break;
                }
            }
            // Wyświetlenie menu powrotu do menu głównego
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego");
            Console.ReadKey();
            ShowMenu(animals);
        }

        // Metoda pokazująca szczegóły zwierzęcia
        private static void ShowAnimalDetails(List<Animal> animals)
        {
            Console.Clear();
            // Sprawdzenie czy lista jest pusta
            if (animals.Count == 0)
            {
                // Wyświetlenie komunikatu o braku zwierząt
                Console.WriteLine("Nie dodano żadnych zwierząt.");
            }
            else
            {
                // Wyświetlenie listy zwierząt z numerami
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + animals[i].Name);
                }

                // Zapytanie użytkownika o numer zwierzęcia
                Console.Write("Podaj numer zwierzęcia, którego szczegóły chcesz zobaczyć: ");
                int index = int.Parse(Console.ReadLine()) - 1;

                // Sprawdzenie czy numer jest poprawny
                if (index >= 0 && index < animals.Count)
                {
                    // Wyświetlenie szczegółów wybranego zwierzęcia
                    Animal animal = animals[index];
                    Console.WriteLine("\n--Szczegóły zwierzęcia--");
                    Console.WriteLine("Nazwa: {0}", animal.Name);
                    Console.WriteLine("Data urodzenia: {0}", animal.BirthDate.ToLongDateString());
                    Console.WriteLine("Czy jest ssakiem: {0}", animal.IsMammal ? "tak" : "nie");
                    Console.WriteLine("Rodzaj: {0}", animal.Kind);
                    animal.ShowAge();
                }
                else
                {
                    // Wyświetlenie komunikatu o błędzie
                    Console.WriteLine("Niepoprawny numer. Spróbuj ponownie.");
                }
            }
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego");
            Console.ReadKey();
            ShowMenu(animals);
        }

        // Metoda pokazująca listę zwierząt
        private static void ShowAnimalList(List<Animal> animals)
        {
            Console.Clear();

            // Sprawdzenie czy lista jest pusta
            if (animals.Count == 0)
            {
                // Wyświetlenie komunikatu o braku zwierząt
                Console.WriteLine("Nie dodano żadnych zwierząt.");
            }
            else
            {
                // Wyświetlanie nazw zwierząt z numerami
                Console.WriteLine("Lista zwierząt: ");
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + animals[i].Name);
                }

            }

            // Wyświetlanie opcji powrotu do menu głównego
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
            Console.ReadKey();
            ShowMenu(animals);
        }

        // Metoda dodające nowe zwierzę
        private static void AddNewAnimal(List<Animal> animals)
        {
            // Wyczyszczenie konsoli
            Console.Clear();

            // Wczytanie danych o zwierzęciu od użytkownika
            Console.Write("Podaj nazwę zwierzęcia: ");
            string name = Console.ReadLine();

            Console.Write("Podaj datę urodzenia zwierzęcia (w formacie RRRR-MM-DD)");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Czy zwierzę jest ssakiem? (tak/nie)");
            bool isMammal = Console.ReadLine().ToLower() == "tak"; // true/false
            Kind kind = Kind.Ssak;
            if (!isMammal)
            {
                Console.Write("Podaj rodzaj zwierzęcia (Ptak, Ryba, Gad, Plaz): ");
                kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine());
            }

            // Utworzenie obiektu klasy animal z podanymi danymi
            Animal animal = new Animal(name, birthDate, isMammal, kind);

            // Dodanie obiektu do listy zwierząt
            animals.Add(animal);

            // Wyświetlenie potwierdzenia
            Console.WriteLine("Dodano nowe zwierzę: " + animal.Name);
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
            Console.ReadKey();
            ShowMenu(animals);
        }
    }
}