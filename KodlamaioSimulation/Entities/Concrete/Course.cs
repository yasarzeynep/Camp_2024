using Core.Entities;

namespace Entities.Concrete;

public class Course : Entity<int>
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseImage { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Situation { get; set; }
    public Instructor Instructor { get; set; }
}
