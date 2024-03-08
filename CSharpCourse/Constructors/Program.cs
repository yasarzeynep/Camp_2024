Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
Customer customer2 = new Customer { Id = 2, FirstName = "Derin", LastName = "Demiroğ", City = "Ankara" };
Customer customer3 = new Customer (  3 ,  "Derin",  "Demiroğ",  "Ankara");
Console.WriteLine(customer3.FirstName + " " + "Yapıcı method calıstı");

static void Method()
{

}
    
class Customer
{
    //default constructor:parametresi olmayan
    public Customer()
    {
    }

    public Customer(int id, string firstname, string lastName, string city) //method parametleri camel  case
    {
        Id = id;
        FirstName = firstname;
        LastName = lastName;
        City = city;
        Console.WriteLine("Değerler set edildi");
    }

    public int Id { get; set;}
    public string FirstName { get; set; }
    public string LastName { get; set;}
    public string City { get; set; }
}
