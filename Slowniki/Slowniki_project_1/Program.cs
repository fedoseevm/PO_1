using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            //####################################################################################


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
            Console.WriteLine();
            //####################################################################################


            // Utwórz słownik, który może przechowywać łańcuchy jako klucze i wartości
            Dictionary<string, string> capital = new Dictionary<string, string>();

            // Dodaj kilka par klucz-wartosc do slownika za pomocą składki inicjalizatora kolekcji
            capital = new Dictionary<string, string>()
            {
                { "Polska", "Warszawa"},
                { "Niemcy", "Berlin"},
                { "Francja", "Paryż"},
                { "Włochy", "Rzym"},
            };

            foreach (var pair in capital)
            {
                Console.WriteLine("Państwo: {0}     Stolica: {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();

            //####################################################################################

            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
            phoneNumbers.Add("+48 123 456 789", "Katarzyna");
            phoneNumbers.Add("+48 123 444 555", "Tomasz");
            phoneNumbers.Add("+48 123 987 654", "Anna");

            // foreach (string number in phoneNumbers)      Daje ERROR
            foreach (KeyValuePair<string, string> number in phoneNumbers)
            {
                Console.WriteLine("Numer telefonu: {0}  osoby: {1}", number.Key, number.Value);
            }
            Console.WriteLine();

            foreach (var number in phoneNumbers.Keys)
            {
                Console.WriteLine("Numer telefonu: {0}  osoby: {1}", number, phoneNumbers[number]);
            }
            Console.WriteLine();

            //####################################################################################

            Dictionary<string, string> animals = new Dictionary<string, string>();
            animals = new Dictionary<string, string>()
            {
                {"pies", "hauhau"},
                {"kot", "miaumiau"},
                {"krowa", "muuu"},
                {"koń", "ihaa"}
            };

            foreach (var animal in animals)
            {
                Console.WriteLine("Zwierze: {0}  Wydaje dźwięk: {1}", animal.Key, animal.Value);
            }
            Console.WriteLine();

            //####################################################################################

            Dictionary<string, string> colors = new Dictionary<string, string>();
            colors = new Dictionary<string, string>()
            {
                {"white", "#FFFFFF"},
                {"black", "#000000"},
                {"red", "#FF0000"},
                {"green", "#00FF00"},
                {"blue", "#0000FF"},
            };

            foreach (KeyValuePair<string, string> color in colors)
            {
                Console.WriteLine("Kolor {0} ma kod {1}", color.Key, color.Value);
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            //####################################################################################

            Dictionary<string, string> data = new Dictionary<string, string>();

            // Proszenie użytkownika o podanie par klucz-wartosc
            Console.Write("Podaj ile par klucz-wartość chcesz wprowadzić: ");
            int n = int.Parse(Console.ReadLine());

            // W pętli pobierzemy od użytkownika klucz i wartość i dodamy do słownika data
            for (int i = 0; i < n; i++)
            {
                Console.Write("Podaj klucz: ");
                string klucz = Console.ReadLine();
                Console.Write("Podaj wartość: ");
                string wartosc = Console.ReadLine();
                data.Add(klucz, wartosc);
                Console.WriteLine("\n");
            }

            foreach (var item in data)
            {
                Console.WriteLine("KLucz {0}, wartosc: {1}", item.Key, item.Value);
            }


            // Napisz funkcję, która przyjmuje jako argument listę liczb całkowitych i zwraca słownik, w którym kluczem jest liczba, a wartością jest jej częstotliwość występowania na liście.
            // Jeśli lista jest pusta lub null, funkcja powinna zwrócić pusty słownik.
            // Przykład: dla listy[1, 2, 3, 2, 4, 1, 5, 2] funkcja powinna zwrócić słownik { 1: 2, 2: 3, 3: 1, 4: 1, 5: 1}.
            // Napisz program, który wczytuje od użytkownika ciąg znaków, próbuje przekonwertować go na liczbę całkowitą za pomocą metody TryParse, a następnie wyświetla wynik na konsoli.
            // Jeśli konwersja się powiedzie, program powinien wyświetlić liczbę i informację, że jest to poprawna liczba całkowita.
            // Jeśli konwersja się nie powiedzie, program powinien wyświetlić informację, że podany ciąg znaków nie jest poprawną liczbą całkowitą.
            // Przykład: dla ciągu znaków “123” program powinien wyświetlić “123 jest poprawną liczbą całkowitą”.
            // Dla ciągu znaków “abc” program powinien wyświetlić “abc nie jest poprawną liczbą całkowitą”.


        }
        // static public Dictionary<int, int> 
        // ...
    }
}
