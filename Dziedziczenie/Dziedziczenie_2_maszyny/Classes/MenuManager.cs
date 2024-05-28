using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_2_maszyny.Classes
{
    internal class MenuManager
    {
        public void DisplayMenu()
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Wyświetl wszystkie maszyny");
            Console.WriteLine("2. Uruchom wszystkie maszyny");
            Console.WriteLine("3. Pracuj wszystkimi maszynami");
            Console.WriteLine("4. Zatrymaj wszystkie maszyny");
            Console.WriteLine("5. Wyświetl status wszystkich maszyn");
            Console.WriteLine("6. Losowe awarie maszyn");
            Console.WriteLine("7. Napraw wszystkie maszyny");
            Console.WriteLine("8. Dodaj nowy typ maszyny");
            Console.WriteLine("9. Dodaj nową maszynę");
            Console.WriteLine("10. Zamknij program");
        }
        public string GetUserInput()
        {
            string input = Console.ReadLine();
            while (!IsValidInput(input, 1, 10))
            {
                ShowErrorMessage("Nieprawidłowa opcja, spróbuj ponownie: ");
                input = Console.ReadLine();
            }
            return input;
        }
        public void ExecuteAction(string userInput, MachineSimulator simulator, MachineTypeManager typeManager)
        {
            int action = int.Parse(userInput);
            switch (action)
            {
                case 1:
                    simulator.DisplayAllMachines();
                    break;
                case 2:
                    simulator.StartAll();
                    break;
                case 3:
                    simulator.WorkAll();
                    break;
                case 4:
                    simulator.StopAll();
                    break;
                case 5:
                    //simulator.DisplayStatusAll();
                    break;
                case 6:
                    //simulator.RandomFailMachines();
                    break;
                case 7:
                    //simulator.RepairAllMachines();
                    break;
                case 8:
                    Console.Write("Podaj nowy typ maszyny: ");
                    string newType = Console.ReadLine();
                    typeManager.AddMachineType(newType);
                    Console.WriteLine($"Typ maszyny {newType} został dodany");
                    break;
                case 9:
                    simulator.AddNewMachine(typeManager);
                    break;
                case 10:
                    Console.WriteLine("Zakończenie programu");
                    break;
                default:
                    ShowErrorMessage("Nieprawidłowa opcja. Spróbuj ponownie: ");
                    break;
            }
        }

        private void ShowErrorMessage(string message)
        {
            Console.Write(message);
        }

        private bool IsValidInput(string input, byte min, byte max)
        {
            return int.TryParse(input, out int number) && number >= min && number <= max;
        }
    }
}
