using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spr_1_28_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // grupa 1
            // Napisz program, który:

            // Definiuje funkcję UtworzTabliceLiczb(int n), która przyjmuje jako parametr liczbę całkowitą n i zwraca tablicę jednowymiarową o długości n, wypełnioną liczbami z zakresu od 1 do 10, które podaje użytkownik z klawiatury
            // Definiuje funkcję ObliczPole(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość pola kwadratu o boku a. Wzór na pole kwadratu to:
            // P = a2

            // Definiuje funkcję ObliczObwod(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość obwodu kwadratu o boku a. Wzór na obwód kwadratu to:
            // O = 4a

            // W funkcji Main:
            // Deklaruje zmienną n i przypisuje jej wartość 5.
            // Wywołuje funkcję UtworzTabliceLiczb(n) i przypisuje jej wynik do zmiennej tablica.
            // Wyświetla na ekranie zawartość tablicy tablica.
            // Dla każdego elementu tablicy tablica:
            // Wywołuje funkcję ObliczPole i przypisuje jej wynik do zmiennej pole.
            // Wywołuje funkcję ObliczObwod i przypisuje jej wynik do zmiennej obwod.
            // Wyświetla na ekranie informację o polu i obwodzie kwadratu o boku równym danemu elementowi tablicy.
            // Napisz funkcję, która umożliwia podanie w parametrze indeksu tablicy a następnie zwróci ona wynik pola i obwodu kwadratu

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int n = 5;
            int[] tablica = UtworzTabliceLiczb(n);
            int i = 0;
            foreach (int item in tablica)
            {
                Console.WriteLine($"tablica[{i}] = {item}");
                i++;
            }
            Console.ReadKey();
            Console.Clear();

            int j = 0;
            foreach (int item in tablica)
            {
                Console.WriteLine($"tablica[{j}] = {item}");
                int a = item;
                int pole = ObliczPole(a);
                Console.WriteLine("Pole kwadratu o długości boku {0} = {1} j\x00b2", a, pole);
                int obwod = ObliczObwod(a);
                Console.WriteLine("Obwód kwadratu o długości boku {0} = {1} j", a, obwod);
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();


            bool isCorrect = false;
            do
            {
                try
                {
                    Console.Write($"Podaj indeks tablicy (liczba całkowita między 0 a {tablica.Length - 1}): ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int index) && index >= 0 && index < tablica.Length)
                    {
                        Console.WriteLine($"\ntablica[{j}] = {tablica[index]}");
                        int pole = ObliczPole(tablica[index]);
                        Console.WriteLine("Pole kwadratu o długości boku {0} = {1} j²", tablica[index], pole);
                        int obwod = ObliczObwod(tablica[index]);
                        Console.WriteLine("Obwód kwadratu o długości boku {0} = {1} j", tablica[index], obwod);
                        Console.WriteLine();
                    }
                    else
                    {
                        throw new ArgumentException($"Długość boku ma być liczbą dodatnią całkowitą w przedziale <0;{tablica.Length  - 1}>.");
                    }
                    isCorrect = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: nieprawidłowy format danych.\n");
                }
            } while (!isCorrect);


        }
        static int[] UtworzTabliceLiczb(int n)
        {
            bool cycleEnd = false;
            int[] T = new int[n];
            while (!cycleEnd)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Podaj {i + 1} element tablicy (liczba całkowita): ");
                    if (int.TryParse(Console.ReadLine(), out int x) && x >= 1 && x <= 10)
                    {
                        T[i] = x;
                    }
                    else
                    {
                        Console.WriteLine("Podana wartość jest niepoprawna. Powinna być liczba całkowita w zakresie od 1 do 10\n");
                        i--;
                    }
                }
                Console.WriteLine("\n");
                cycleEnd = true;
            }
            return T;
        }
        static int ObliczPole(int a)
        {
            int p = a * a;
            return p;
        }

        static int ObliczObwod(int a)
        {
            int obw = a * 4;
            return obw;
        }
    }
}
