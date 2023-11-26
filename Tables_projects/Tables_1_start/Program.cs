using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables_1_start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ZADANIE 1
            // Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program wyświetla sumę wszystkich elementów tablicy.
            /*
                        int[] table_ex1 = new int[5];
                        int sum = 0;
                        for (int i = 0; i < table_ex1.Length; i++)
                        {
                            Console.Write($"Podaj {i + 1} element tablicy (liczba calkowita): ");
                            table_ex1[i] = int.Parse(Console.ReadLine());
                            sum += table_ex1[i];
                        }
                        Console.WriteLine("\nSuma elementow tablicy: {0}", sum);
            */

            // ZADANIE 2
            // Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program wyświetla sumę wszystkich elementów tablicy.
            // W celu zabezpieczenia programu przed niepoprawnymi danymi wejściowymi, użyliśmy metody int.TryParse(), która pozwala na sprawdzenie, czy wprowadzona wartość jest liczbą całkowitą. Jeśli użytkownik wprowadzi niepoprawną wartość, program wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.

            int[] table_ex2 = new int[5];
            int sum2 = 0;
            for (int i = 0; i < table_ex2.Length; i++)
            {
                Console.Write($"Podaj {i + 1} element tablicy (liczba calkowita): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    table_ex2[i] = number;
                }
                else
                {
                    Console.WriteLine($"\nNiepoprawna wartosc. Wprowadz liczbe calkowita w zakresie <{int.MinValue};{int.MaxValue}>.\n");
                    i--;
                }
            }

            for (int i = 0; i < table_ex2.Length; i++)
            {
                sum2 += table_ex2[i];
            }
            Console.WriteLine("\nSuma elementow tablicy: {0}", sum2);


            // Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla sumę wszystkich elementów tablicy. Kod ten wykorzystuje metodę GetIntegerFromUser(), która pobiera od użytkownika liczbę całkowitą i zwraca ją. Jeśli użytkownik wprowadzi niepoprawną wartość, funkcja wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby. 

            // Funkcja CalculateSum(int[] numbers) przyjmuje tablicę liczb całkowitych i zwraca ich sumę.

            int[] table_ex3 = new int[5];
            for (int i = 0; i < table_ex3.Length; i++)
            {
                table_ex3[i] = GetIntegerfromUser();
            }

            int sum3 = CalculateSum(table_ex3);
            Console.WriteLine("\nSuma liczb tablicy: {0}", sum3);


            //// Istnieje jednak wbudowana funkcja Sum()
            //int sum4 = table_ex3.Sum();
            //Console.WriteLine(sum4);

            // Console.WriteLine(Enumerable.Sum(table_ex3));


        }
        static int GetIntegerfromUser()
        // metoda GetIntegerfromUser() pobiera od użytkownika liczbę całkowitą i zwraca ją
        {
            while (true)
            {
                Console.Write("Podaj liczbę całkowitą: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Niepoprawna wartość. Wprowadź liczbę całkowitą.");
                }
            }
        }
        static int CalculateSum(int[] table)
        // Funkcja CalculateSum(int[] numbers) przyjmuje tablicę liczb całkowitych i zwraca ich sumę
        {
            int sum = 0;
            foreach (int i in table)
                sum += i;
            return sum;
        }
    }
}
