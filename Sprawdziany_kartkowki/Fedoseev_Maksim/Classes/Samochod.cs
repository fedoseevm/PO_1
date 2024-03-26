using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedoseev_Maksim.Classes
{
    enum TypPaliwa
    {
        Benzyna,
        Diesel,
        Elektryczny,
        Hybrydowy
    }

    internal class Samochod
    {
        static int IloscKol = 4;
        private string Marka;
        private string Model;
        private int RokProdukcji;
        public DateTime DataPierwszejRejestracji { get; set; }
        public float PojemnoscSilnika { get; set; }
        public TypPaliwa TypPaliwa { get; set; }



        public Samochod()
        {
            Marka = "Nieznana";
            Model = "Nieznany";
            RokProdukcji = 0;
        }

        public Samochod(string marka, string model, int rokProdukcji, DateTime dataPierwszejRejestracji, TypPaliwa typPaliwa, float pojemnoscSilnika)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rokProdukcji;
            DataPierwszejRejestracji = dataPierwszejRejestracji;
            PojemnoscSilnika = pojemnoscSilnika;
            TypPaliwa = typPaliwa;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Rok produkcji: {RokProdukcji}");
            Console.WriteLine($"Data pierszej rejestracji: {DataPierwszejRejestracji.ToShortDateString()}");
            Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika}");
            Console.WriteLine($"Typ paliwa: {TypPaliwa}");
        }

        public int ObliczWiek()
        {
            int wiek = DateTime.Now.Year - RokProdukcji;
            return wiek;
        }

        public void ZmienMarkeIModel(string marka, string model)
        {
            Marka = marka;
            Model = model;
        }

        public bool CzyKlasyk()
        {
            if (DateTime.Now.Year - RokProdukcji > 25)
                return true;
            return false;
        }

        public void WyswietlInformacjeJSON()
        {

        }

        public double ObliczSpalanie(double przejechaneKm, double zuzytePaliwo)
        {
            double spalanie =  zuzytePaliwo/ przejechaneKm * 100;
            return Math.Round(spalanie, 2);
        }
    }
}
