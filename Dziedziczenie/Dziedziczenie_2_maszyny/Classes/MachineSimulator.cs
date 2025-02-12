﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_2_maszyny.Classes
{
    // Klasa zarządzająca grupą maszyn
    internal class MachineSimulator
    {
        private List<Machine> machines = new List<Machine>();
        // Metoda dodająca maszynę do symulatora
        public void Add(Machine machine)
        {
            machines.Add(machine);
        }
        public void AddNewMachine(MachineTypeManager typeManager)
        {
            typeManager.DisplayMachineTypes();
            Console.Write("Wybierz typ maszyny do dodania: ");
            string machineType = Console.ReadLine();
            if (typeManager.IsValidType(machineType))
            {
                Machine newMachine = MachineFactory.CreateMachine(machineType);
            }
            else
            {
                Console.WriteLine("Nieznany typ maszyny");
            }
        }

        // Metoda uruchamiająca wszystkie maszyny
        public void StartAll()
        {
            foreach (var machine in machines)
            {
                machine.Start();
            }
        }

        // Metoda symulująca pracę wszystkich maszyn
        public void WorkAll()
        {
            foreach (var machine in machines)
            {
                machine.Work();
            }
        }

        // Metoda zatrzymująca wszystkie maszyny
        public void StopAll()
        {
            foreach (var machine in machines)
            {
                machine.Stop();
            }
        }

        // Metoda wyświetlająca wszystkie maszyny
        public void DisplayAllMachines()
        {
            foreach (var machine in machines)
            {
                Console.WriteLine(machine.Name);
            }
        }
    }
}
