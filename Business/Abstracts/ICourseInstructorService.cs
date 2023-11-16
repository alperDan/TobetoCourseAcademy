using System;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface ICourseInstructorService
	{
        List<CourseInstructor> GetAll();
        List<CourseInstructor> GetAllByInstructorId(int id);
        List<CourseInstructor> GetAllByCourseId(int id);
    }
}

