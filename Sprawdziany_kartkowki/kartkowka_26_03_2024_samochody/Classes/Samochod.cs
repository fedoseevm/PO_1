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
        public TypPaliwa TypPaliwa { get; set; }
        public float PojemnoscSilnika { get; set; }



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
            TypPaliwa = typPaliwa;
            PojemnoscSilnika = pojemnoscSilnika;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Rok produkcji: {RokProdukcji}");
            Console.WriteLine($"Data pierszej rejestracji: {DataPierwszejRejestracji.ToShortDateString()}");
            Console.WriteLine($"Typ paliwa: {TypPaliwa}");
            Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika}");
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
            Console.Write("{");
            Console.Write("\n\t\"Marka\": \"{0}\", \n\t\"Model\": \"{1}\", \n\t\"RokProdukcji\": {2}, \n\t\"DataPierwszejRejestracji\": {3}, \n\t\"TypPaliwa\": \"{4}\", \n\t\"PojemnoscSilnika\": {5} \n\t", Marka, Model, RokProdukcji, DataPierwszejRejestracji.ToShortDateString(), TypPaliwa, PojemnoscSilnika);
            Console.Write("}");
        }

        public double ObliczSpalanie(double przejechaneKm, double zuzytePaliwo)
        {
            double spalanie =  zuzytePaliwo/ przejechaneKm * 100;
            return Math.Round(spalanie, 2);
        }
    }
}
