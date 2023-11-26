﻿using System;
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
            // KOLOKCJE zmieniaja rozmiar i sa dynamiczne

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
            // funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę(CreateArray)
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
            Random r = new Random();
            int n = int.Parse(Console.ReadLine());
            int[,] tabB = new int[n, n];
            int sum = 0;
            for (int i = 0; i < tabB.GetLength(0); i++)
            {
                for (int j = 0; j < tabB.GetLength(1); j++)
                {
                    tabB[i,j] = r.Next(1, 100);
                    if (i == j)
                    {
                        sum += tabB[i, j];
                    }

                }
            }
            Console.WriteLine(sum);

        }
        // PUBLIC pozwala korzystac z metody w MAIN
        public static int[] CreateArray(string name)
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
            int[] array = new int[size];
            return array;
        }

        public static void SetArray(int[] array, string name)
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