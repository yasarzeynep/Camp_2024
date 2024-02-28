using Classes;

public class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.UpDate();

        ProductManager productManager = new ProductManager();
        customerManager.Add();
        customerManager.UpDate();

        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Test0";
        customer.LastName = "Test00";

        Customer customer1 = new Customer
        {
            Id=2, City= "İstanbul", FirstName="Test1", LastName= "Test11"
        };

        Console.WriteLine(customer1);
    }
}



