using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrect = false;
            do
            {
                try
                {
                    Console.WriteLine("Podaj dwie liczby");
                    Console.Write("Podaj x: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Podaj y: ");
                    int y = int.Parse(Console.ReadLine());
                    Console.Write($"\nWynik dzielenia ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    //Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{x} / {y} = {x / y}");
                    Console.ResetColor();
                    isCorrect = true;
                }
                catch (FormatException)
                {
                    //Console.WriteLine("Błąd: błędny format danych");
                    ErrorColorChange("błędny format danych");
                }
                catch (OverflowException)
                {
                    //Console.WriteLine($"Błąd: wartość podana przez użytkownika przekracza zakres liczby <{int.MinValue};{int.MaxValue}>");
                    ErrorColorChange($"wartość podana przez użytkownika przekracza zakres liczby <{int.MinValue};{int.MaxValue}>");
                }
                catch (DivideByZeroException)
                {
                    //Console.WriteLine("Błąd: dzielenie przez zero");
                    ErrorColorChange("dzielenie przez zero");
                }
                //catch (ArithmeticException ex)
                catch (Exception ex)
                {
                    // Console.WriteLine($"Błąd: {ex.Message}");
                    ErrorColorChange($"{ex.Message}");

                    // Błąd: Nieprawidłowy format ciągu wejściowego.
                    // Błąd: Wartość jest za duża albo za mała dla wartości typu Int32.
                    // Błąd: Nastąpiła próba podzielenia przez zero.
                }
                finally // zawsze się wykonuje, wykonuje się na końcu
                {
                    Console.WriteLine("\n\nDziękujemu za korzystanie z programu!\n\n");
                    // Niestety wypisuje się za każdym razem, kiedy występuje błąd
                }
            } while (!isCorrect);
            
        }
        static void ErrorColorChange(string comment)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Błąd: {comment}");
            Console.ResetColor();
        }
    }
}
