using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_table_index_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch do obsługi wyjątków. Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
            // Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby.

            int[] array = new int[5];
            do
            {
                Console.WriteLine("Wprowadź 5 liczb całkowitych: ");
                try
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"Podaj liczbę {i + 1}: ");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowe dane. Wprowadź poprawną liczbę całkowitą.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Nieprawidłowe dane. Liczba jest poza zakresem <{int.MinValue};{int.MaxValue}>");
                }
                break;
            } while (true);

            int index = 0;
            string input = "";

            do
            {
                Console.Write("\nWprowadź indeks tablicy lub q, aby zakończyć: ");
                input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }


                try
                {
                    index = int.Parse(input);
                    Console.WriteLine($"Liczba pod indeksem {index} to {array[index]}");
                    if (index > array.Length - 1)
                    {
                        throw new OverflowException($"Nieprawidłowe dane. Indeks musi być między 0 a {array.Length - 1} ");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowe dane. Wprowadź poprawną liczbę całkowitą.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"Nieprawidłowe dane. Indeks musi być między 0 a {array.Length - 1}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Nieprawidłowe dane. {ex.Message}");
                }
            } while (true);
        }
    }
}
