using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tables_2
{
    internal class Program
        // DEFINIOWANIE KLAS
    {
        // STATIC pozwala wywolac metode nie tworzac obiektu
        static void Main(string[] args)
        {
            // WLASCIWOSC 
            // METODA 
            // OBIEKTY wskazuja miejsca w pamiecy, gdzie sa przechowywane wartosci, a nie same wartosci
            // KOLOKACJE zmieniaja rozmiar i sa dynamiczne

            // TYPY WARTOSCIOWE
            // TYPY REFERENCYJNE
            // tablice sa typu referencyjnego

            // Deklaracja tablic w rozny sposob
            // int[] liczby1 = new int[] { 1, 2, 3, 4, 5 };
            // int[] liczby2 = { 1, 2, 3, 4, 5 };
            // var liczby3 = { 1, 2, 3, 4, 5 };

            // for wykorzystijemy, kiedy wiemy rozmiar tablicy
            // foreach - kiedy rozmiar jest nieznany


            // ZADANIE 1
            // funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę (CreateArray)
            // funkcja statyczna, która ustawia elementy tablicy (SetArray)
            // funkcja statyczna, która wyświetla zawartość tablicy (DisplayArray)

            int[] tabA = CreateArray("tabA");
            if (tabA != null)
            {
                SetArray(tabA, "tabA");
                DisplayArray(tabA, "tabA");
            }



            // ZADANIE 2
            // Napisz program, który wczytuje z klawiatury liczbę n i tworzy tablicę dwuwymiarową o wymiarach n x n. Następnie program wypełnia tablicę liczbami losowymi z zakresu od 1 do 100 i wyświetla jej zawartość na ekranie. Na koniec program oblicza i wyświetla sumę elementów znajdujących się na głównej przekątnej tablicy.
            Console.WriteLine("Zadanie 2");
            Random r = new Random();
            bool isCorrect = false;
            do
            {
                Console.Write("Podaj długość tablicy: ");
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new ArgumentException("Długość tablicy powinna być dodatnia.");
                    }
                    int[,] tabB = new int[n, n];
                    Console.WriteLine("ilość wymiarów tablicy: " + tabB.Rank);   // Zwraca ilość wymiarów tablicy
                    int sum = 0;
                    for (int i = 0; i < tabB.GetLength(0); i++)
                    {
                        for (int j = 0; j < tabB.GetLength(1); j++)
                        {
                            tabB[i, j] = r.Next(1, 100);
                            Console.Write(tabB[i, j] + " ");
                            if (i == j)
                            {
                                sum += tabB[i, j];
                            }

                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Suma elementów znajdujących się na głównej przekątnej tablicy: " + sum);
                    isCorrect = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Wystąpił błąd: {ex.Message}\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wystąpił błąd: nieprawidłowy format danych.\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Wystąpił błąd: długość tablicy nie może przekraczać {int.MaxValue}\n");
                }
            } while (!isCorrect);


        }
        // PUBLIC pozwala korzystac z metody w MAIN
        public static int[] CreateArray(string name)
        // funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę (CreateArray)
        {
            Console.Write($"Podaj rozmiar tablicy <0 ; {int.MaxValue}> {name}: ");
            int size = 0;
            try
            {
                size = int.Parse(Console.ReadLine());
                if (size <= 0) throw new ArgumentException("Rozmiar talbicy musi byc dodatni\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("\nWystąpił błąd: {0}", ex.Message);
                return null;
            }
            catch (FormatException)
            {
                Console.WriteLine("Wystąpił błąd: Nieprawidłowy format danych.");
                return null;
            }
            int[] array = new int[size];
            return array;
        }

        public static void SetArray(int[] array, string name)
        // funkcja statyczna, która ustawia elementy tablicy (SetArray)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < array.Length; i++)
            {
                
                Console.Write($"Podaj {i + 1} element talbicy {name}: ");
                try
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nWystąpił błąd: {0}", ex.Message);
                    i--;
                }
            }
        }

        public static void DisplayArray(int[] array, string name)
        // funkcja statyczna, która wyświetla zawartość tablicy (DisplayArray)
        {
            Console.WriteLine($"\nElementy tablicy {name}: ");
            int i = 0;
            foreach (int item in array)
            {
                Console.WriteLine($"{name}[{i}]: {item}");
                i++;
            }
            Console.WriteLine("\n");
        }
    }
}
