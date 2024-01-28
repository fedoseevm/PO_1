using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie listy liczb całkowitych 
            // List - klasa generyczna, przyjmuje jako parametr typ elementów, które ma przechowywać 
            List<int> ints = new List<int>();
            // ... = new List<int>() - przypisanie wartości do zmiennej 


            // Tworzenie listy liczb całkowitych z początkowymi elementami, używając inicjalizatora kolekcji 
            // List<int>() - konstruktor domyślny nie przyjmujący paramentru 

            // List<int> ints2 = new List<int>() { 1, 2, 3, 4, 5 };

            // Dodawanie elementów do listy za pomocą metody Add()
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            // wywołanie metody Add na ints

            // Usuwanie elementów z listy za pomocą metody Remove()
            ints.Remove(2);

            // wyświetlenie długości listy za pomocą metody Count()
            Console.WriteLine("Długość tablicy: {0}", ints.Count());

            // wyświetlenie elementów listy
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();




            // Zadanie 1
            Console.WriteLine("\nZadanie 1");
            // •	Utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
            // •	Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne przez 3 lub 5.
            // •	Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.
            Console.WriteLine("Liczba list losowych");

            // 1. Tworzenie obiektu generatora liczb losowych
            Random r = new Random();

            List<int> list1 = new List<int>(); 

            // 2. Wypełnienie listy 10 losowymi liczbami z zakresu 1 - 100
            for (int i = 0; i < 10; i++)
            {
                list1.Add(r.Next(1, 100 + 1));
                // przedzial lewostronnie domknięty i prawostronnie otwarty
            }
            foreach (int element in list1)
            {
                Console.Write(element + " ");
            }

            // 3.1 Tworzenie metodydivisibleBy3or5()
            // 3.2 Wywołanie metody divisibleBy3or5(), która zwraca listę liczb całkowitych podzielnych przez 3 lub 5
            List<int> listDivisibleBy3or5 = divisibleBy3or5(list1);

            // 4. Wyświetlenie końcowej listy
            Console.WriteLine("\n\nLista z liczbami podzielnymi przez 3 lub 5");
            foreach (int item in listDivisibleBy3or5)
            {
                Console.Write($"{item} ");
            }


            Console.ReadKey();
            Console.Clear();

            // Zadanie 2
            Console.WriteLine("Zadanie 2");

            // Napisz program, który tworzy listę liczb całkowitych i wypełnia ją losowymi wartościami z zakresu od 1 do 100.
            // Napisz program, który wyświetla menu z pięcioma opcjami, co chcesz zrobić z listą:
            // - Wyświetlić listę liczb podzielnych przez 3 lub 5
            // - Wyświetlić listę liczb nieparzystych
            // - Wyświetlić listę liczb posortowanych rosnąco
            // - Wyświetlić listę liczb posortowanych malejąco
            // - Wyjść z programu
            // Napisz metodę dla każdej opcji, która przyjmuje jako parametr listę liczb i zwraca listę liczb spełniających warunek danej opcji.
            // Napisz kod, który obsługuje wybór użytkownika i wywołuje odpowiednią metodę, a następnie wyświetla wynikową listę na konsoli.
            // Napisz kod, który powtarza wyświetlanie menu i obsługę wyboru, dopóki użytkownik nie wybierze opcji wyjścia z programu.
            Console.WriteLine("Lista losowych liczb całkowitych: ");
            List<int> list2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list2.Add(r.Next(1, 100 + 1));
            }
            foreach (int element in list2)
            {
                Console.Write(element + " ");
            }

            Console.ReadKey();
            Console.Clear();

            int choice;
            // Tworzenie pętli do wyświetlenia menu o obsługi wyboru
            do
            {
                // Wyświetlenie menu
                Console.WriteLine("\n\nMenu (Podaj liczbę 1-4 lub [5] dla wyjścia): ");
                Console.WriteLine("[1] Wyświetlić listę liczb podzielnych przez 3 lub 5 [1]");
                Console.WriteLine("[2] Wyświetlić listę liczb nieparzystych [2]");
                Console.WriteLine("[3] Wyświetlić listę liczb posortowanych rosnąco [3]");
                Console.WriteLine("[4] Wyświetlić listę liczb posortowanych malejąco [4]");
                Console.WriteLine("Wyjść z programu [5]");

                // Pobieranie wyboru od użytkownika
                Console.Write("\nPodaj swój wybór: ");
                choice = int.Parse(Console.ReadLine());


                // Wykonanie
                switch (choice)
                {
                    case 1:
                        // Wywołanie metody divisibleBy3or5(), którazwraca liczbę liczb podzielnych przez 3 lub 5
                        List<int> divisible = divisibleBy3or5(list2);

                        // Wyświetlenie wynikowej listy
                        Console.WriteLine("\nLista liczb podzielnych przez 3 lub 5: ");
                        foreach (int item in divisible)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        // Wywołanie metody onlyOddNumbers(), która wyświetla listę liczb nieparzystych
                        List<int> odd = onlyOddNumbers(list2);

                        Console.WriteLine("\nLista liczb nieparzystych: ");
                        foreach (int item in odd)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // Wywołanie metody SortAsc(), która wyświetla listę liczb posortowanych rosnąco
                        List<int> ascending = SortAsc(list2);

                        Console.WriteLine("\nLista liczb posortowanych rosnąco");
                        foreach (int item in ascending)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        // Wywołanie metody SortDesc(), która wyświetla listę liczb posortowanych rosnąco
                        List<int> descending = SortDesc(list2);

                        Console.WriteLine("\nLista liczb posortowanych malejąco");
                        foreach (int item in descending)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (choice != 5);
            


            Console.WriteLine("\n");
        }
        // Metoda, która przyjmuje listę liczb, a zwraca listę liczb podzielnych przez 3 lub 5
        static public List<int> divisibleBy3or5(List<int> listOfInts)
        {
            // Tworzenie pustej listy result
            List<int> result = new List<int>();

            // Iterowanie (przechodzenie) po elementach listy i sprawdzenie warunku podzielności
            foreach (int element in listOfInts)
            {
                if (element % 3 == 0 || element % 5 == 0)
                    result.Add(element);
            }
            return result;
        }

        // Metoda, która przyjmuje listę liczb i zwraca listę liczb nieparzystych
        static public List<int> onlyOddNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (int element in list)
            {
                if (element % 2 == 1)
                    result.Add(element);
            }
            return result;
        }

        static public List<int> SortAsc(List<int> list)
        {
            List<int> result = new List<int>();
            list.Sort();
            result = list;
            return result;
        }
        static public List<int> SortDesc(List<int> list)  // Dokończyć
        {
            List<int> result = new List<int>();
            list.Sort();
            list.Reverse();
            result = list;
            return result;
        }
    }
}
