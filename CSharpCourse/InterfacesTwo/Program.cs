

        //interface new'lenemez.
        //IPersonManager personManager = new IPersonManager();

        //IPersonManager customerManager = new CustomerManager(); 
        //Interfaceler referans tiptir. Heap'de CustomerManager'ın bir referans değeri oluşuyor.
        //IPersonManager'da bu referans değerini tutabiliyor.
        //Yani interfaceler onu implemente eden (new CustomerManager();) class'ın referans numarasını tutabilirler.

        IPersonManager customerManager = new CustomerManager(); //CustomerManager referansını tutar.
        customerManager.Add();
        IPersonManager employeeManager = new EmployeeManager(); //EmployeeManager referansını tutar.
        employeeManager.Add();




//class PersonManager
//{  
//implemented operation
//    public void Add() 
//    {
//        Console.WriteLine("Eklendi");
//    }
//}
//class CustomerManager : PersonManager
//{ }

interface IPersonManager //Şablon belirliyoruz. void Add() imzasını kullanmak zorunda fakat kendi kodlarını yazabilir.
{
    //unimplemented operation
    void Add(); //Default public tir. Burada içini doldurmuyoruz. Imzası aynı olabilir fakat CustomerManager için ayrı EmployeeManager için ayrı kodlar içerir.
    void Update();
}

//inherits-class ------ implements-interface ( implement =":") 
class CustomerManager : IPersonManager //Şablona uymak zorunda: İmzalar aynı ve  kod içerikleri farklı
{
    public void Add() //Burada imzalar aynı fakat içerisindeki kodlar farklıdır.
    {
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi.");
    }
}

class EmployeeManager : IPersonManager //Şablona uymak zorunda: İmzalar aynı ve kod içerikleri farklı
{
    public void Add()
    {
        //Personel ekleme kodları 
        Console.WriteLine("Personel eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi.");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Intern eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Intern güncellendi.");
    }
}

class ProjectManager
{
    //Herzaman tek bir nesneyle değil birden fazla nesneyle çalışılır
    //public void AddCustomer(CustomerManager customerManager) //Hatalı
    //{
    //    customerManager.Add();
    //}

    //public void AddEmployee(EmployeeManager employeeManager) //Hatalı
    //{
    //    employeeManager.Add();
    //}

    public void Add(IPersonManager personManager)
    //Parametre olarak interface alır. Buraya IPersonManager'dan implement edilen tüm class'lar gönderilebilir.
    //Bu bize yazılımda değişimi sağlar.
    //CustomerManager ve EmployeeManager varken InternManager ekleyip IPersonManager'dan implement ederiz.
    //Kendi operasyon kodlarını yazarız (Add, Update).
    //Fakat ProjectManager için birşey değiştirmemiz gerekmez çünkü IPersonManager kabul ediyor.
    //InternManager'da IPersonManager'dan implement edildiği için kabul edecektir.

    {
        personManager.Add();
    }
}
