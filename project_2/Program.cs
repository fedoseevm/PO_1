using System;
using System.Collections.Generic;
using System.Linq;  // Obsluguje zapytania
using System.Text;  // kodowanie znakow ASCII i symboli
using System.Threading.Tasks; 

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args) // METODA glowna
        {
            Console.WriteLine("C#");
            Console.Clear(); // czyszczenie ekranu
            Console.ReadKey();  // Console - klasa
                                // ReadKey() - metoda
                                // KOMPILATOR - program do przemiany zwyklego tekstu do komend rozumianych przez program. Tlumaczy zwyklu kod programistyczny na kod maszynowy. C, C++, C#, Java
                                // C# -> CIL -> kod posredni -> kod maszynowy

            // INTERPRETER - program ktora czyta i analizuje kod programu i wykonuje go na biezaco. Python, JavaScript
            // kod -> interpreter

            // "C:\Users\2e1\2E MF\ProgObiektowe_1\project_2" - sciezka bezwzgledna

            // zmienne - deklaracja i inicjalizacja
            int i = 10; // 32 bity -> 4 bajty -> System.Int32
            // int: -2 147 483 648 - 2 147 483 647
            Console.WriteLine("Wartosc wynosi: " + i);      // + - Konkatynacja
            Console.WriteLine("Wartosc wynosi: {0}", i);    // ??????????????????????
            System.Int64 j = 100;
            Console.WriteLine("Wartosc zmiennej j: {0}, a wartosc zmiennej i: {1}", j, i);
            // System.Int => 16, 32, 64

            long l = 20;
            Console.WriteLine("Zmienna l: {0}", l);
            byte b = 255;   // byte: 0-255
            sbyte sb = -128; // sbyte: -128 - 127

            short s = -30000; // short: -32768 - 326767
            Console.ReadKey();

            // dokonczyc zmienne (uint)
        }
    }
}
