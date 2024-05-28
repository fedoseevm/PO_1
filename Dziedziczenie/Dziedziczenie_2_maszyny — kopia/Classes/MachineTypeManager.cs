using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_2_maszyny.Classes
{
    internal class MachineTypeManager
    {
        private List<string> machineTypes = new List<string>();
        public MachineTypeManager()
        {
            // Dodajemy domyślne typy maszyn
            machineTypes.Add("Koparka");
            machineTypes.Add("Dźwig");
            machineTypes.Add("Spychacz");
            machineTypes.Add("Ładowarka");
        }
        public void AddMachineType(string type)
        {
            if (!machineTypes.Contains(type))
            {
                machineTypes.Add(type);
                Console.WriteLine($"Typ maszyny {type} został dodany");
            }
            else
            {
                Console.WriteLine($"Typ maszyny {type} już istnieje");
            }
        }
        public void DisplayMachineTypes()
        {
            Console.WriteLine("Dostępne typy maszyn: ");
            foreach (var type in machineTypes)
            {
                Console.WriteLine($"- {type}");
            }
        }
        public bool IsValidType(string type)
        {
            return machineTypes.Contains(type);
        }
    }
}
