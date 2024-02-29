using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces;

public interface ICustomerDal
{
    void Add();
    void Update ();
    void Delete();

}

class SqlServerCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Sql added");
    }


    public void Delete()
    {
        Console.WriteLine("Sql deleted");
    }

    public void Update()
    {
        Console.WriteLine("Sql updated");
    }
}
class OracleCustomerDal : ICustomerDal
{
    public void Add()
    {
        Console.WriteLine("Oracle deleted");
    }

    public void Delete()
    {
        Console.WriteLine("Oracle added");
    }

    public void Update()
    {
        Console.WriteLine("Oracle updated");
    }
}

class MsqlCustomerDal : ICustomerDal
{
    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}

public class CustomerManager
    {
    
     public void Add(ICustomerDal customerDal)
    {
        customerDal.Add();

    }
    
    }

