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

            string input;
            do
            {
                Console.Write("Podaj liczbę całkowitą lub 0 lub q, aby wyjść z programu: ");
                input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    int number = int.Parse(input);
                    if (number < 0)     // własny wyjątek
                    {
                        throw new ArgumentOutOfRangeException("Liczba nie może być ujemna\n\n");
                    }

                    if (number > 0)
                    {
                        double sqrt = Math.Sqrt(number);
                        Console.WriteLine($"Pierwiastek z {number} wynosi {sqrt}\n\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy dane wejściowe. Podaj prawidłową liczbą całkowitą\n\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Nieprawidłowy dane wejściowe. Przekroczono zakres liczby <{int.MinValue};{int.MaxValue}>\n\n");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"\nBłąd: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("\n\nDziękujemy za korzystanie z programu\n\n");
                }
            } while (input != "0");
        }
    }
}
