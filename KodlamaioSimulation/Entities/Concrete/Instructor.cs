using Core.Entities;
using System.Reflection.Metadata;

namespace Entities.Concrete;

public class Instructor:Entity<int>
{
    public Instructor(string firstName, string lastName, string ımage)
    {
        FirstName = firstName;
        LastName = lastName;
        Image = ımage;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Image { get; set; }
}
