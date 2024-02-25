using Core.Entities;

namespace Entities.Concrete;

public class Category : Entity<int>
{
   public string CategoryChoice { get; set; }

    public ICollection<Course> Categories { get; set;}
}
