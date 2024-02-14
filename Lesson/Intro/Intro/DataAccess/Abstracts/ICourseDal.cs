using Intro.Entities;

namespace Intro.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetaAll();
    void Add(Course course);

}
