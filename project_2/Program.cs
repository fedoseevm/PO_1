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
                             //Console.ReadKey();  // Console - klasa
                             // ReadKey() - metoda

            // KOMPILATOR - program do przemiany zwyklego tekstu do komend rozumianych przez program. Tlumaczy zwykly kod programistyczny na kod maszynowy. C, C++, C#, Java
            // C# -> CIL (Common Intermediate Language - Wspólny język pośredni) -> kod posredni -> kod maszynowy

            // INTERPRETER - program ktora czyta i analizuje kod programu i wykonuje go na biezaco. Python, JavaScript
            // kod -> interpreter


            // "C:\Users\2e1\2E MF\ProgObiektowe_1\project_2" - sciezka bezwzgledna

            // Zmienne - deklaracja i inicjalizacja
            Console.WriteLine("Zmienne - deklaracja i inicjalizacja\n");
            int i = 10; // 32 bity -> 4 bajty -> System.Int32
            // int: -2 147 483 648 - 2 147 483 647
            Console.WriteLine("Wartosc wynosi: " + i);      // + - Konkatynacja
            Console.WriteLine("Wartosc wynosi: {0}", i);    // ??????????????????????
            System.Int64 j = 100;
            Console.WriteLine("Wartosc zmiennej j: {0}, a wartosc zmiennej i: {1}", j, i);
            // System.Int => 16, 32, 64


            byte b = 255;   // byte: 0-255
            sbyte sb = -128; // sbyte: -128 - 127
            short s = -30000; // short: -32768 - 32767
            //Console.ReadKey();
            /* ---------------------
             * byte 0-255 (8 bitow => 1 bajt)
             * sbyte -128 - 127 (8 bitow => 1 bajt)
             * ---------------------
             * short -32 768 - 32 767 (16 bitow => 2 bajt)
             * ushort 65 536 (16 bitow => 2 bajt)
             * ---------------------
             * int -2 147 483 648 - 2 147 483 647 (32 bity => 4 bajty)
             * uint 0 - 4 294 967 295 (32 bity => 4 bajty)
             * ---------------------
             * long -9 223 372 036 854 755 808 - 9 223 372 036 854 755 807 (64 bity => 8 bajtow) sufix L
             * ulong 0 - 18 446 744 073 709 551 615 (64 bity => 8 bajtow) sufix UL
             * ---------------------
             * float -3.4 * 10^38 do 3.4 * 10^38 (32 bity) sufix F
             * double (64 bity)
             * decimal (128 bitow)
             * ---------------------
             * bool (true or false) (1 bajt)
             * char U+0000 to U+FFFF (16 bitow => 2 bajty, znak z tablicy Unicode)
             * string ?
             */

            long l = -20;
            ulong ul = 20UL;
            Console.WriteLine("Zmienna l: {0}, zmienna ul: {1}", l, ul);

            float f = 10.5F;
            Console.WriteLine("Zmienna f: {0}", f); // 10,5

            float f1 = 10;
            Console.WriteLine(f1); // 10


            Console.WriteLine("Ilosc bajtow w pamieci typu float: " + sizeof(float));
            Console.WriteLine("Ilosc bajtow w pamieci typu int: " + sizeof(int));
            Console.WriteLine("Ilosc bitow w pamieci typu int: " + Math.Pow(2, sizeof(int) * 8));
            Console.WriteLine("Ilosc bajtow w pamieci typu bool: " + sizeof(bool));
            Console.ReadKey();
            Console.Clear();

            // zapis systemow liczbowych
            Console.WriteLine("Zapis systemow liczbowych \n");
            // binarny
            Console.WriteLine(0b1010); // 10

            // oktalny
            Console.WriteLine(011);
            int i2 = Convert.ToInt32("12", 8);
            Console.WriteLine("Zamiana liczby oktalnej na dziesietna: " + i2); // 12(8) => 1x8^1 + 2x8^0

            // heksadecymalny
            Console.WriteLine(0xA); // 10

            // zakres danego typu
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine(int.MinValue);          // -2 147 483 648
            Console.WriteLine(Int32.MinValue);        // -2 147 483 648
            Console.WriteLine(System.Int32.MinValue); // -2 147 483 648

            Console.WriteLine(System.Int64.MinValue); // -9 223 372 036 854 775 808
            Console.WriteLine(System.Byte.MaxValue);

            Console.ReadKey();
            Console.Clear();

            // UNICODE
            Console.WriteLine("UNICODE \n");
            Console.OutputEncoding = System.Text.Encoding.Unicode; // Rozwazanie problemu
            Console.WriteLine("♫");
            Console.WriteLine("\x266B");

            char letter = 'a';
            Console.WriteLine(letter);
            
            char letter2 = (char)97;
            Console.WriteLine(letter2);
            Console.WriteLine("\ud83c\udca9"); // ????????????
            Console.ReadKey();
        }
    }
}
