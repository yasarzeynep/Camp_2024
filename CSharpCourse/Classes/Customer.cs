using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Classes;

public class Customer
{
    public int Id { get; set; } //Property

    private string _firstName;
    public string FirstName {
        get { return "Mr." + _firstName; }

        set { _firstName = value; }
    }
    public string LastName { get; set; }
    public string City { get; set; }
}
