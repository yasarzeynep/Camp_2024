using Interfaces;

InterfacesIntro();

Demo();

ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MsqlCustomerDal()
};
static void InterfacesIntro()
{
    PersonManager manager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirstName = "Engin",
        LastName = "Demiroğ",
        Address = "Ankara"

    };


    Student student = new Student
    {
        Id = 2,
        FirstName = "Derin",
        LastName = "Demiroğ",
        Departmant = "Math"

    };
    manager.Add(student);
    manager.Add(customer);
    //manager.Add(worker);
}

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new SqlServerCustomerDal());
}

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }

}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}
class PersonManager
{
    //public void Add (Customer customer)
    // {
    //     Console.WriteLine("add a customer");
    // }

    // public void Add(Student student)
    // {
    //     Console.WriteLine("add a student");
    // } 

    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }

}