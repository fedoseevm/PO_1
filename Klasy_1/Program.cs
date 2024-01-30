using Klasy_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person nowak = new Person();
            //nowak.FirstName = "Nowak";
            nowak.SetFirstName("Pawlak");
            Console.WriteLine("Nazwisko: {0}", nowak.FirstName);

            Student s1 = new Student();
            s1.StudentNumber = "12345";
            Console.WriteLine("Numer indeksy studenta: " + s1.StudentNumber);

            Teacher t1 = new Teacher();
            t1.Subjects = new List<string>() { "matematyka", "informatyka", "Programonwanie obiektowe" };
            //foreach (var subject in t1.Subjects)
            //	Console.Write(subject + " ");

            //Console.WriteLine("\n" + string.Join(", ", t1.Subjects));

            Console.WriteLine(t1.GetSubjects());

            // W Visual Studio
            // Prawym przyciskiem na nazwę projektu -> New Folder -> nazwać go "Classes"
            // Następnie prawym przyciskiem na utworzony folder -> Add -> Class -> Wybrać "Class" i wprowadzić nazwę klasy pole -> Enter
            // Pojawia się plik w folderze "Classes", gdzie trzeba wkleić kod odpowiedniej klasy z głównego pliku
            // Usunąć deklarację klasy w głównym pliku i połączyć go z utworzoną osobno klasą, wpisując <using Klasy_1.Classes>; 

            nowak.Adress = new Adress();
            nowak.Adress.City = "Poznań";
            nowak.Adress.Street = "Polna";
            nowak.Adress.HouseNumber = "1b/2";
            nowak.Adress.PostalCode = "12-345";

            Console.WriteLine("Adres: " + nowak.Adress.GetAdress());

            nowak.DateOfBirth = DateTime.Now;
            Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth); 
            //Data urodzenia: 23.01.2024 09:24:05

            nowak.DateOfBirth = new DateTime();
            Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth); 
            //Data urodzenia: 01.01.0001 00:00:00

            nowak.DateOfBirth = new DateTime(2000 - 2 - 14);
            Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth); 
            //Data urodzenia: 01.01.0001 00:00:00

            nowak.DateOfBirth = new DateTime(2000, 2, 14);
            Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth); 
            //Data urodzenia: Data urodzenia: 14.02.2000 00:00:00
            
            nowak.DateOfBirth = new DateTime(2000, 2, 14);
            Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth.ToShortDateString()); 
            //Data urodzenia: 14.02.2000

            Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth.ToLongDateString()); 
            //Data urodzenia: poniedziałek, 14 lutego 2000

            nowak.DateOfBirth = new DateTime(2000, 2, 14, 9, 29, 55);
            Console.WriteLine("Czas urodzenia: {0}", nowak.DateOfBirth.ToShortTimeString());
            //Czas urodzenia: 09:29

            Console.WriteLine("Czas urodzenia: {0}", nowak.DateOfBirth.ToLongTimeString()); 
            //Czas urodzenia: 09:29:55

            Console.WriteLine("Data i czas urodzenia: {0} {1}", nowak.DateOfBirth.ToLongDateString(), nowak.DateOfBirth.ToLongTimeString());

            Console.WriteLine("\nLekcja 2");
            Person p1 = new Person();       // enum
            p1.Gender = Gender.mężczyzna;
            Console.WriteLine(p1.Gender);

            p1.Permission = Permission.User;

            p1.DateOfBirth = new DateTime(2000, 1, 25, 9, 14, 49);

            p1.SetFirstName("Adam");
            p1.SetLastName("Nowak");
            Console.WriteLine(p1.GetData()); // Imię i nazwisko: Adam Nowak, zwrost: 0cm, waga: 0kg
            Console.WriteLine("Data urodzenia: " + p1.DateOfBirth.ToLongDateString() + " rok");
            p1.Adress = new Adress();
            p1.Adress.City = "Poznań";
            Console.WriteLine(p1.Adress.GetAdress()); // Miasto: Poznań, ulica:  , kod pocztowy:    

            Console.ReadKey();
        }
    }
}
