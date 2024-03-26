using Fedoseev_Maksim.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedoseev_Maksim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testowanie metod
            Console.WriteLine("samochod1");
            Samochod samochod1 = new Samochod();
            samochod1.WyswietlInformacje();
            Console.WriteLine("\n");

            Console.WriteLine("samochod2");
            Samochod samochod2 = new Samochod("Fiat", "500", 2018, new DateTime(2018, 5, 20), TypPaliwa.Benzyna, 1.2f);
            samochod2.WyswietlInformacje();
            Console.WriteLine("Wiek samochodu: {0}", samochod2.ObliczWiek());
            Console.WriteLine("Czy jest klasykiem: {0}", samochod2.CzyKlasyk());

            Console.WriteLine("\nWyświetlenie danych w formacie JSON: ");
            samochod2.WyswietlInformacjeJSON();

            Console.WriteLine("\n\nSpalanie(l / 100km): {0}", samochod2.ObliczSpalanie(500, 50));

            Console.WriteLine("\n\nAby skończyć testowanie metod i przejść do CarMenu, naciśnij dowolny klawisz");
            Console.ReadKey();

            List<Samochod> Samochody = new List<Samochod>();
            ShowMenu(Samochody);
        }

        private static void ShowMenu(List<Samochod> samochody)
        {
            Console.Clear();

            Console.WriteLine("Witamy w programie zarządzania samochodami!\n");
            Console.WriteLine("Wybierz jedną z opcji: ");
            Console.WriteLine("1. Dodaj samochód");
            Console.WriteLine("2. Wyświetl informacje o samochodach");
            Console.WriteLine("3. Oblicz wiek samochodu");
            Console.WriteLine("4. Sprawdź, czy klasyk");
            Console.WriteLine("5. Wyświetl informacje JSON");
            Console.WriteLine("6. Oblicz spalanie");
            Console.WriteLine("7. Zakończ program");

            Console.Write("\nWykonaj: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    DodajSamochod(samochody);
                    break;
                case "2":
                    WyswietlInfo(samochody);
                    break;
                case "3":
                    ObliczWiekSamochodu(samochody);
                    break;
                case "4":
                    SprawdzCzyKlasyk(samochody);
                    break;
                case "5":
                    WyswietlListeSamochodowJSON(samochody);
                    break;
                case "6":
                    ObliczSpalanieSamochodu(samochody);
                    break;
                case "7":
                    Console.WriteLine("\nDziękujemy za korzystanie z programu!");
                    break;
                default:
                    Console.WriteLine("Podana niepoprawna wartość. Spróbuj ponownie.");
                    Console.ReadKey();
                    ShowMenu(samochody);
                    break;
            }
        }

        private static void DodajSamochod(List<Samochod> samochody)
        {
            Console.Clear();

            try
            {
                Console.Write("Podaj markę samochodu: ");
                string marka = Console.ReadLine();

                Console.Write("Podaj model samochodu: ");
                string model = Console.ReadLine();

                Console.Write("Podaj rok produkcji samochodu: ");
                int rokProdukcji = int.Parse(Console.ReadLine());
                if (rokProdukcji < 1886 || rokProdukcji > DateTime.Now.Year)
                    throw new Exception();

                Console.Write("Podaj datę pierwszej rejestracji samochodu w formacie YYYY-MM-DD: ");
                DateTime dataPierwszejRejestracji = DateTime.Parse(Console.ReadLine());
                if (dataPierwszejRejestracji.Year < 1886 || dataPierwszejRejestracji.Year > DateTime.Now.Year)
                    throw new Exception();

                Console.Write("Podaj typ paliwa samochodu (Benzyna, Diesel, Elektryczny, Hybrydowy): ");
                TypPaliwa typPaliwa = (TypPaliwa)Enum.Parse(typeof(TypPaliwa), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine()));

                Console.Write("Podaj pojemność silnika: ");
                float pojemnoscSilnika = float.Parse(Console.ReadLine());

                Samochod samochod = new Samochod(marka, model, rokProdukcji, dataPierwszejRejestracji, typPaliwa, pojemnoscSilnika);
                samochody.Add(samochod);
                Console.WriteLine("\nDodano nowy samochód: ");
                samochod.WyswietlInformacje();
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                Console.ReadKey();
                ShowMenu(samochody);
            }
            catch (Exception)
            {
                Console.WriteLine("\nBłędne dane. \nNaciśnij dowolny klawisz, aby spróbować ponownie.");
                Console.ReadKey();
                DodajSamochod(samochody);
            }
        }

        private static void WyswietlInfo(List<Samochod> samochody)
        {
            Console.Clear();
            if (samochody.Count() == 0)
            {
                Console.WriteLine("Nie dodano żadnego samochodu");
            }
            else
            {
                for (int i = 0; i < samochody.Count; i++)
                {
                    Console.WriteLine($"Samochód {i + 1}: ");
                    samochody[i].WyswietlInformacje();
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
            Console.ReadKey();
            ShowMenu(samochody);
        }

        private static void ObliczWiekSamochodu(List<Samochod> samochody)
        {
            Console.Clear();

            if (samochody.Count() == 0)
            {
                Console.WriteLine("Nie dodano żadnego samochodu");
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                Console.ReadKey();
                ShowMenu(samochody);
            }
            else
            {
                GetCarList(samochody);
                try
                {
                    Console.Write("\nPodaj numer samochodu, wiek którego chcesz obliczyć: ");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    int wiek = samochody[index].ObliczWiek();
                    if (wiek % 10 == 1)
                        Console.WriteLine($"Wiek {index + 1} samochoda: {wiek} rok");
                    else if (wiek % 10 > 1 && wiek % 10 < 5)
                        Console.WriteLine($"Wiek {index + 1} samochoda: {wiek} lata");
                    else
                        Console.WriteLine($"Wiek {index + 1} samochoda: {wiek} lat");
                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                    Console.ReadKey();
                    ShowMenu(samochody);
                }
                catch (Exception)
                {

                    Console.WriteLine("\nPodana niepoprawna wartość. \nNaciśnij dowolny klawisz, aby spróbować ponownie.");
                    Console.ReadKey();
                    ObliczWiekSamochodu(samochody);

                }
            }
        }

        private static void SprawdzCzyKlasyk(List<Samochod> samochody)
        {
            Console.Clear();

            if (samochody.Count() == 0)
            {
                Console.WriteLine("Nie dodano żadnego samochodu");
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                Console.ReadKey();
                ShowMenu(samochody);
            }
            else
            {
                GetCarList(samochody);
                try
                {
                    Console.Write("\nPodaj numer samochodu, aby się dowiedzieć, czy jest klasykiem: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    if (samochody[index].CzyKlasyk())
                    {
                        Console.WriteLine($"Samochód o numerze {index + 1} JEST KLASYKIEM");
                    }
                    else
                    {
                        Console.WriteLine($"Samochód o numerze {index + 1} NIE JEST KLASYKIEM");
                    }
                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                    Console.ReadKey();
                    ShowMenu(samochody);
                }
                catch (Exception)
                {

                    Console.WriteLine("\nPodana niepoprawna wartość. \nNaciśnij dowolny klawisz, aby spróbować ponownie.");
                    Console.ReadKey();
                    SprawdzCzyKlasyk(samochody);
                }
            }
        }

        private static void WyswietlListeSamochodowJSON(List<Samochod> samochody)
        {
            Console.Clear();

            Console.Write("[\n\t");
            for (int i = 0; i < samochody.Count; i++)
            {
                samochody[i].WyswietlInformacjeJSON();
                if (i != samochody.Count - 1)
                    Console.Write(",\n\t");
            }
            Console.WriteLine("\n]");

            Console.ReadKey();
            ShowMenu(samochody);
        }

        private static void ObliczSpalanieSamochodu(List<Samochod> samochody)
        {
            Console.Clear();

            if (samochody.Count() == 0)
            {
                Console.WriteLine("Nie dodano żadnego samochodu");
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                Console.ReadKey();
                ShowMenu(samochody);
            }
            else
            {
                GetCarList(samochody);
                try
                {
                    Console.Write("\nPodaj numer samochodu, spalanie którego chcesz obliczyć: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    Console.Clear();
                    samochody[index].WyswietlInformacje();

                    Console.Write("\nPodaj, ile km przejechałeś: ");
                    int przejechaneKm = int.Parse(Console.ReadLine());
                    if (przejechaneKm <= 0)
                        throw new Exception();

                    Console.Write("Podaj, ile paliwa zużyłeś (litry): ");
                    double zuzytePaliwo = Math.Round(double.Parse(Console.ReadLine()), 1);
                    if (zuzytePaliwo <= 0)
                        throw new Exception();

                    Console.WriteLine($"\nSpalanie samochoda {index + 1} wynosi: {samochody[index].ObliczSpalanie(przejechaneKm, zuzytePaliwo)} l/100km");

                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego.");
                    Console.ReadKey();
                    ShowMenu(samochody);
                }
                catch (Exception)
                {
                    Console.WriteLine("\nPodana niepoprawna wartość. \nNaciśnij dowolny klawisz, aby spróbować ponownie.");
                    Console.ReadKey();
                    ObliczSpalanieSamochodu(samochody);
                }
            }

        }

        private static void GetCarList(List<Samochod> samochody)
        {
            Console.WriteLine("Lista samochodów: ");
            for (int i = 0; i < samochody.Count; i++)
            {
                Console.WriteLine($"Samochód {i + 1}: ");
                samochody[i].WyswietlInformacje();
                Console.WriteLine("\n");
            }
        }
    }
}
