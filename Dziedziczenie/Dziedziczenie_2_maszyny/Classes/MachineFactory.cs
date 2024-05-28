using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_2_maszyny.Classes
{
    internal class MachineFactory
    {
        public static Machine CreateMachine(string machineType)
        {
            switch (machineType)
            {
                case "Koparka":
                    return new Excavator("Nowa koparka", MachineType.Excavator);
                case "Dźwig":
                    return new Excavator("Nowy dźwig", MachineType.Crane);
                case "Spychacz":
                    return new Excavator("Nowy spychacz", MachineType.Bulldozer);
                case "Ładowarka":
                    return new Excavator("Nowa ładowarka", MachineType.Loader);
                default:
                    throw new ArgumentException("Nieznany typ maszyny");
            }
        }
    }
}
