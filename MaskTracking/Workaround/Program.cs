using Business.Concrete;
using Entities.Concrete;
using System.Security.Cryptography;

namespace Workaround;
class Program
{
    static void Main(string[] args)
    {
        // Variables();
        Citizen citizen = new Citizen();
        //citizen.name = "Test";  
        int result = Add(3, 5);

        //Arrays(Diziler)
        string student1 = "Engin";
        string student2 = "Kerem";
        string student3 = "Berkay";

        Console.WriteLine(student1);
        Console.WriteLine(student2);
        Console.WriteLine(student3);

        string[] students = new string [3];
        students[0] = student1;
        students[1] = student2;
        students[2] = student3;

        students = new string[4];
        students[2] = "İlker" ;
        for (int i = 0; i<students.Length; i++) 
        {
            Console.WriteLine(students[i]);
        }

        string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
        string[] cities2 = { "Bursa", "Antalya", "Diyarbakır" };

        cities2 = cities1;
        cities1[0] = "Adana";
        Console.WriteLine(cities2[0]);

        Person person1 = new Person();
        person1.FirstName = "Engin";
        person1.LastName = "Demiroğ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 1;

        Person person2 = new Person();
        person2.FirstName = "Murat";


        foreach (string city in cities1)
        {
            Console.WriteLine(city);

        }
        //MyList
        List<string> newCities = new List<string> { "Ankara 1 ", " İstanbul  2", "İzmir 3" };
        newCities.Add("Adana 1");
        foreach(var city in newCities)
        {
            Console.WriteLine(city);
        }

        PttManager pttManager = new PttManager(new ForeignerManager());
        pttManager.GiveMask(person1);


        SelamVer(name:"Ali");
        SelamVer();
    }
    static void SelamVer(string name="test")
    {
        Console.WriteLine("Hello" + name);
    }

    static int Add(int sayi1, int sayi2)
    {
        int result = sayi1 + sayi2;
        Console.WriteLine("Result" +  result.ToString() );
        return result;
    }
    private static void Variables()
    {
        string message = "Hello";
        double amount = 100000; //db 
        int number = 100;
        bool loggedIn = false;

        string name = "Engin";
        string surname = "Demiroğ";
        int birthYear = 1985;
        string tcNumber = "12345678910";

        Console.WriteLine(message);
        Console.ReadLine();
    }
}

public class Citizen
{
   //public string name = "Engin";
   //public string surname = "Demiroğ";
   //public int birthYear = 1985;
   //public string tcNumber = "12345678910";

        public   string  Name { get; set; }
        public   string  SurName { get; set; }
        public   string  BirthYear { get; set; }
        public   string  TcNumber { get; set; }
    }