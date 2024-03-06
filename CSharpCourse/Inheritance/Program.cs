using System;

Customer  customer=new Customer();
Person[] persons=new Person[3]
{
    new Customer { FirstName = "Engin" },
    new Student { FirstName = "Derin" } ,
    new Person{FirstName="Salih"}
};

foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}

class Person2
{

}
interface IPerson
{

}

class Person
{
    //field 
    //public int Id; burada field değil Property kullanılır.

    //Property
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

class Customer : Person, IPerson // Person2 :bir kere inheritance alınır
{                                //Once inheritance yazılır, sonra interfaceler yazılır
    public string City { get; set; }
}

class Student : Person
{
 public string Department { get; set; }
}