using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedoseev_Maksim.Classes
{
    enum Color
    {
        white,
        black,
        red,
        green,
        blue

    }

    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public ushort Year { get; set; }
        public float Price { get; set; }
        public Person Owner { get; set; }

        public string GetInfo()
        {
            return $"Marka: {Brand}, Model: {Model}, Kolor: {Color}, Rok:{Year}, Cena: {Price} PLN. \nWłaściciel: {Owner.Name} {Owner.LastName}, Data urodzenia: {Owner.DateOfBirth.ToShortDateString()}. \nDzieci włąściciela: {GetOwnersChildrenNames()}";
        }

        public string GetOwnersChildrenNames()
        {
            return string.Join(", ", Owner.children_names);
        }

        // NIE DZIALA
        //public string GetColors()
        //{
        //    return string.Join(", ", Color);
        //}
    }
}
