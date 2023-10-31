using System;

namespace sqrt_exeptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program w C#, który wczytuje liczbę całkowitą od użytkownika i oblicza jej pierwiastek kwadratowy.
            //Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
            //Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby.
            //Program powinien działać w pętli, dopóki użytkownik nie wpisze 0 lub q.Użyj instrukcji try-catch-finally do obsługi wyjątków.

            //string input;
            //do
            //{
            //    Console.Write("Podaj liczbę całkowitą lub 0 lub q, aby wyjść z programu: ");
            //    input = Console.ReadLine();
            //    if (input == "q")
            //    {
            //        break;
            //    }
            //    try
            //    {
            //        int number = int.Parse(input);
            //        if (number < 0)     // własny wyjątek
            //        {
            //            throw new ArgumentOutOfRangeException("Liczba nie może być ujemna\n\n");
            //        }

            //        if (number > 0)
            //        {
            //            double sqrt = Math.Sqrt(number);
            //            Console.WriteLine($"Pierwiastek z {number} wynosi {sqrt}\n\n");
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Nieprawidłowy dane wejściowe. Podaj prawidłową liczbą całkowitą\n\n");
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine($"Nieprawidłowy dane wejściowe. Przekroczono zakres liczby <{int.MinValue};{int.MaxValue}>\n\n");
            //    }
            //    catch (ArgumentOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"\nBłąd: {ex.Message}");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("\n\nDziękujemy za korzystanie z programu\n\n");
            //    }
            //} while (input != "0");


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
