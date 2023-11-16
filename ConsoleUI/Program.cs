

using Business.Concretes;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;

namespace ConsoleUI
{
internal class Program
    {
         private static void Main(string[] args)
        {
            //CourseNames();

            //InstructorGetName();

            CourseManager courseManager = new CourseManager(new CourseDal());

            var result = courseManager.GetCourseDetails();
            if (result.Success==true)
            {
                foreach (var course in result.Data)
                {
                Console.WriteLine(course.CourseName+"/"+course.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            

            Console.ReadLine();
        }









        private static void CourseNames()
        {
            CourseManager courseManager = new CourseManager(new CourseDal());

            foreach (var instructor in courseManager.GetAll().Data)
            {
                Console.WriteLine(instructor.CourseName);
            }
        }

        private static void InstructorGetName()
        {
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());

            foreach (var instructor in instructorManager.GetAll())
            {
                Console.WriteLine(instructor.Name ?? "Name is null");
            }
        }
    }
}

    

