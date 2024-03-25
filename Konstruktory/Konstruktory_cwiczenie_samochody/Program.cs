using Konstruktory_cwiczenie_samochody.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory_cwiczenie_samochody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car c1 = new Car("RX5", "Nissan", "2005-09-02", 512, "suv");
            //Console.WriteLine(c1.Model + " " + c1.Manufacturer + " " + c1.ProductionDate + " " + c1.HorsePowers + " " + c1.Type);

            List<Car> Cars = new List<Car>();
            ShowMenu(Cars);
        }

        static void ShowMenu(List<Car> cars)
        {
            Console.Clear();

            Console.WriteLine("Witaj w programie zarządzania samochodami!");
            Console.WriteLine("Wybierz jedną z opcji: ");
            Console.WriteLine("1. Dodaj samochód");
            Console.WriteLine("2. Pokaż listę samochodów");
            Console.WriteLine("3. Pokaż szczegóły samochoda");
            Console.WriteLine("4. Usuń samochód z listy");
            Console.WriteLine("5. Zakończ program");

            Console.Write("\nWykonaj: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddNewCar(cars);
                    break;
                case "2":
                    ShowCarList(cars);
                    break;
                case "3":
                    ShowCarDetails(cars);
                    break;
                case "4":
                    DeleteCar(cars);
                    break;
                case "5":
                    Console.WriteLine("\nDziękujemy za korzystanie z programu!\n\n");
                    break;
                default:
                    Console.WriteLine("Niepoprawna opcja. Naciśnij dowolny klawisz i spróbuj ponownie.");
                    Console.ReadKey();
                    ShowMenu(cars);
                    break;
            }
        }

        private static void AddNewCar(List<Car> cars)
        {
            Console.Clear();

            try
            {
                Console.Write("Podaj model samochodu: ");
                string model = Console.ReadLine();

                Console.Write("Podaj producenta samochodu: ");
                string manufacturer = Console.ReadLine();

                Console.Write("Podaj datę produkcji samochodu w formacie YYYY-MM-DD: ");
                string productionDate = Console.ReadLine();

                Console.Write("Podaj rodzaj samochodu (Sedan, SUV, Coupe, Sport): ");
                string type = Console.ReadLine();

                Console.Write("Czy samochód ma silnik diesla (tak/nie): ");
                bool isDiesel = Console.ReadLine().ToLower() == "tak";

                Console.Write("Ile samochód ma koni: ");
                int horsePowers = int.Parse(Console.ReadLine());

                Car samochod = new Car(model, manufacturer, productionDate, horsePowers, type, isDiesel);
                cars.Add(samochod);

                Console.WriteLine("\nDodano nowy samochód: {0} {1} {2}", samochod.Manufacturer, samochod.Model, samochod.ProductionDate.Year);
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                Console.ReadKey();
                ShowMenu(cars);
            }
            catch (Exception)
            {
                Console.WriteLine("\nBłędne dane, spróbój ponownie. \nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                Console.ReadKey();
                ShowMenu(cars);
            }
        }
        private static void GetCarList(List<Car> cars)
        {
            Console.WriteLine("Lista samochodów: ");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Manufacturer} {cars[i].Model} {cars[i].ProductionDate.Year}");
            }
        }
        private static void ShowCarList(List<Car> cars)
        {
            Console.Clear();

            if (cars.Count == 0)
            {
                Console.WriteLine("Nie dodano żadnego samochodu.");
            }
            else
            {
                GetCarList(cars);

            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
            Console.ReadKey();
            ShowMenu(cars);
        }

        private static void ShowCarDetails(List<Car> cars)
        {
            Console.Clear();

            if (cars.Count == 0)
            {
                Console.WriteLine("Nie dodano żadniego samochodu.");
            }
            else
            {
                GetCarList(cars);

                Console.Write("\nPodaj numer samochodu, którego szczegóły chcesz zobaczyć: ");
                int index = int.Parse(Console.ReadLine()) - 1;

                if (index >= 0 && index < cars.Count)
                {
                    Car samochod = cars[index];
                    Console.WriteLine("\nModel: {0}", samochod.Model);
                    Console.WriteLine("Producent: {0}", samochod.Manufacturer);
                    Console.WriteLine("Rodzaj: {0}", samochod.Type);
                    Console.WriteLine("Data produkcji: {0}", samochod.ProductionDate.ToShortDateString());
                    Console.WriteLine("Ilosc koni: {0}", samochod.HorsePowers);
                    Console.WriteLine("Silnik diesla: {0}", samochod.IsDiesel ? "tak" : "nie");
                }
                else
                {
                    Console.WriteLine("Niepoprawny numer. Spróbuj ponownie.");
                }
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
            Console.ReadKey();
            ShowMenu(cars);
        }

        private static void DeleteCar(List<Car> cars)
        {
            Console.Clear();
            if (cars.Count == 0)
            {
                Console.WriteLine("Nie dodano żadniego samochodu.");
            }
            else
            {
                Console.WriteLine("Wybierz jedną z opcji:");
                Console.WriteLine("1. Usunąc jeden samochód z listy");
                Console.WriteLine("2. Usunąc wszystkie samochody");

                try
                {
                    Console.Write("\nWybór: ");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            Console.Clear();
                            GetCarList(cars);
                            Console.Write("\nPodaj numer samochoda, którego chcesz usunąć: ");
                            int index = int.Parse(Console.ReadLine()) - 1;
                            
                            Console.Clear();
                            Console.WriteLine($"Usunięto samochód o numerze {index + 1}: {cars[index].Manufacturer} {cars[index].Model} {cars[index].ProductionDate.Year}");
                            cars.RemoveAt(index);
                            break;
                        case "2":
                            cars.Clear();
                            Console.WriteLine("\nUsunięto wszystkie samochody z listy.");
                            break;
                        default:
                            Console.WriteLine("\nPodana niepoprawna wartość.");
                            break;
                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("\nBłędne dane, spróbój ponownie.");
                }

                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                Console.ReadKey();
                ShowMenu(cars);

            }
        }
    }
}
