
using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Conretes;

public class EfCourseDal : ICourseDal
{
    List<Course> Courses;
    public EfCourseDal()
    {
    
        Course course1 = new Course(); //Referans oluşturmak
        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Description = ".NET 8 vs ..";
        course1.Price = 0;

        Course course2 = new Course(); //Referans oluşturmak
        course1.Id = 2;
        course2.Name = "JAVA";
        course2.Description = ".Java 17...";
        course2.Price = 10;


        Course course3 = new Course(); //Referans oluşturmak
        course3.Id = 3;
        course3.Name = "Phyton";
        course3.Description = "Phyton 3.12..";
        course3.Price = 20;

        courses = new List<Course> { course1, course2, course3 };

    }
  
    public void Add(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetaAll()
    {
        //sql  öğren
        //db işlemleri yapılır.
        return courses;
    }
}