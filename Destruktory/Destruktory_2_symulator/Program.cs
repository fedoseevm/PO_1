using Destruktory_2_symulator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destruktory_2_symulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

            while (true)
            {

                DisplayMenu();
                int choice = GetUserInput();

                switch (choice)
                {
                    case 1:
                        AddCar(cars, carDictionary);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Lista samochodów: ");
                        DisplayCars(carDictionary);
                        Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                        Console.ReadKey();
                        break;
                    case 3:
                        DriveCar(carDictionary);
                        break;
                    case 4:
                        SimulateDamage(carDictionary);
                        break;
                    case 5:
                        ScrapCar(cars, carDictionary);
                        break;
                    case 6:
                        Console.WriteLine("Zamykanie symolatora.");
                        return;
                    default:
                        Console.WriteLine("Podana niepoprawna wartość. Spróbuj jeszcze raz");
                        break;
                }

            }
        }

        private static void ScrapCar(List<Car> cars, Dictionary<int, Car> carDictionary)
        {
            Console.Clear();
            DisplayCars(carDictionary);
            int scrappedCarNumber = GetUserInput(carDictionary);
            Console.WriteLine($"Samochód {carDictionary[scrappedCarNumber].Brand} {carDictionary[scrappedCarNumber].Model} został zezłomowany");
            cars.RemoveAt(scrappedCarNumber);
            carDictionary.Remove(scrappedCarNumber);

            //// JAK PONIŻEJ ROBIĆ NIE MOŻNA!
            //Car scrappedCar = carDictionary[scrappedCarNumber];
            //// Wywołanie destruktora, który usunie obiekt
            //scrappedCar = null; // Opcjonalnie: wyzerowanie referencji, aby przyspieszyć zwolnienie pamięci
            //GC.Collect();       // Opcjonalnie: wywołanie Garbage Collector, aby natychmiast usunąć obiekt
        }

        private static void SimulateDamage(Dictionary<int, Car> carDictionary)
        {
            Console.Clear();
            DisplayCars(carDictionary);
            int damagedCarNumber = GetUserInput(carDictionary);
            Car damagedCar = carDictionary[damagedCarNumber];
            damagedCar.SimulateRandomDamage();
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
            Console.ReadKey();
        }

        private static void DriveCar(Dictionary<int, Car> carDictionary)
        {
            Console.Clear();
            DisplayCars(carDictionary);
            int carNumber = GetUserInput(carDictionary);
            Car carToDrive = carDictionary[carNumber];
            carToDrive.Drive();
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
            Console.ReadKey();
        }

        static void DisplayCars(Dictionary<int, Car> carDictionary)
        {
            foreach (KeyValuePair<int,Car> car in carDictionary)
            {
                Console.WriteLine($"{car.Key}. {car.Value.Brand} {car.Value.Model}");
            }
        }

        static void AddCar(List<Car> cars, Dictionary<int, Car> carDictionary)
        {
            Console.Clear();
            Console.Write("Podaj markę samochodu:");
            string brand = Console.ReadLine();
            Console.Write("Podaj model samochodu:");
            string model = Console.ReadLine();

            Car newCar = new Car(brand, model);
            cars.Add(newCar);
            carDictionary[cars.Count] = newCar;
            Console.WriteLine("\nDodano nowy samochód!");
            Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu głównego.");
            Console.ReadKey();
        }

        /*static int GetUserInput()
        {
            while (true)
            {
                Console.Write("\nWybierz opcję: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    return choice;
                }
                Console.WriteLine("\nBłędnie wprowadzone dane. Spróbój ponownie.");
            }
        }*/
        
        // Nie wykorzystaliśmy przeciążenia metody, tylko skorzystaliśmy z parametru opcjonalnego
        static int GetUserInput(Dictionary<int, Car> carDictionary = null)
        {
            int input;
            while (true)
            {
                Console.Write("\nPodaj numer: ");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (carDictionary == null || carDictionary.ContainsKey(input))
                    {
                        return input;
                    }
                    Console.WriteLine("\nNumer samochodu nie istnieje w słowniku.");
                }
                else
                {
                    Console.WriteLine("\nNieprawidłowy format. Spróbuj ponownie.");
                }
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu symulatora jazdy samochodem");
            Console.WriteLine("1. Dodaj samochód");
            Console.WriteLine("2. Wyświetl listę samochodów");
            Console.WriteLine("3. Jedź samochodem");
            Console.WriteLine("4. Symuluj losowe uszkodzenie");
            Console.WriteLine("5. Zezłomuj samochód");
            Console.WriteLine("6. Wyjście");
        }
    }
}
