using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_klasy
{
  internal class Program
  {
    class Person
    {
      public string FirstName { get; private set; }
      public string LastName { get; set; }
      public float Height { get; set; }
      public float Weight { get; set; }
      public DateTime DateOfBirth { get; set; }
      public Adress Adress { get; set; }
      
      public void SetFirstName(string firstname)
      {
      	FirstName = firstname;
      }
    }
    class Student
    {
    	public string StudentNumber { get; set; }
    }
    class Teacher
    {
    	public List<string> Subjects { private get; set; }
        
        public string GetSubjects()
        {
        	return string.Join(", ", Subjects);
        }
    }
    class Adress
    {
    	public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        
        public string GetAdress()
        {
        return $"Miasto: {City}, ulica: {Street} {HouseNumber}, kod pocztowy: {PostalCode}";
        }
    }
    
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
      t1.Subjects = new List<string>() { "matematyka", "informatyka" };
      //foreach (var subject in t1.Subjects)
      //	Console.Write(subject + " ");
      
      //Console.WriteLine("\n" + string.Join(", ", t1.Subjects));
      
      Console.WriteLine(t1.GetSubjects());
      
      // W Visual Studio
      // Prawym przyciskiem na nazwę projektu -> New Folder -> nazwać go "Classes"
      // Następnie prawym przyciskiem na utworzony folder -> Add -> Class -> Wybrać "Class" i wprowadzić nazwę klasy pole -> Enter
      // Pojawia się plik w folderze "Classes", gdzie trzeba wkleić kod odpowiedniej klasy z głównego pliku
      // Usunąć deklarację klasy w głównym pliku i połączyć go z utworzoną osobno klasą
      
      nowak.Adress = new Adress();
      nowak.Adress.City = "Poznań";
      nowak.Adress.Street = "Polna";
      nowak.Adress.HouseNumber = "1b/2";
      nowak.Adress.PostalCode = "12-345";
      
      Console.WriteLine("Adres: " + nowak.Adress.GetAdress());
      
      nowak.DateOfBirth = Datetime.Now;
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth);
      
      nowak.DateOfBirth = Datetime();
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth);
      
      nowak.DateOfBirth = Datetime(2000-2-14);
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth);
      
      nowak.DateOfBirth = Datetime(2000, 2, 14);
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth);
      
      nowak.DateOfBirth = Datetime(2000, 2, 14);
      Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth.ToShortDateString());
      
      nowak.DateOfBirth = Datetime(2000, 2, 14, 9, 29, 57);
      Console.WriteLine("Czas urodzenia: {0}", nowak.DateOfBirth.ToShortTimeString());
      
      nowak.DateOfBirth = Datetime(2000, 2, 14, 9, 29, 57);
      Console.WriteLine("Czas urodzenia: {0}", nowak.DateOfBirth.ToLongTimeString());
    }

  }
}
