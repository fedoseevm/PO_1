using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Konstruktory_cwiczenie_samochody.Classes
{
    enum Type
    {
        Unknown,
        Sedan,
        SUV,
        Coupe,
        Sport
    }

    internal class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ProductionDate { get; set; }
        public int HorsePowers { get; set; }
        public Type Type { get; set; }
        public bool IsDiesel { get; set; }

        public Car()
        {
            Model = "Unknown";
            Manufacturer = "Unknown";
            ProductionDate = DateTime.MinValue;
            HorsePowers = 0;
            Type = Type.Unknown;
            IsDiesel = false;
        }

        public Car(string model)
        {
            Model = model;
            Manufacturer = "Unknown";
            ProductionDate = DateTime.MinValue;
            HorsePowers = 0;
            Type = Type.Unknown;
            IsDiesel = false;
        }

        public Car(string model, string manufacturer) : this(model)
        {
            Manufacturer = manufacturer;
        }

        public Car(string model, string manufacturer, string productionDate) : this(model, manufacturer)
        {
            ProductionDate = DateTime.Parse(productionDate);
        }

        public Car(string model, string manufacturer, string productionDate, int horsePowers) : this(model, manufacturer, productionDate)
        {
            HorsePowers = horsePowers;
        }

        public Car(string model, string manufacturer, string productionDate, int horsePowers, string type) : this(model, manufacturer, productionDate, horsePowers)
        {
            if (type.ToUpper() == "SUV")
                Type = (Type)Enum.Parse(typeof(Type), type.ToUpper());
            else
                Type = (Type)Enum.Parse(typeof(Type), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(type));   
            // Kapitalizacja podanego string'a zachowującego typ samochoda od razu przy tworzeniu obiekta klasy
        }

        public Car(string model, string manufacturer, string productionDate, int horsePowers, string type, bool isDiesel) : this(model, manufacturer, productionDate, horsePowers, type)
        {
            IsDiesel = isDiesel;
        }
    }
}
