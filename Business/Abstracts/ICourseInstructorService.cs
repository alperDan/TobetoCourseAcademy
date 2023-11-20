using System;
using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface ICourseInstructorService
	{
        IDataResult<List<CourseInstructor>> GetAll();
        IDataResult<List<CourseInstructor>> GetAllByInstructorId(int id);
        IDataResult<List<CourseInstructor>> GetAllByCourseId(int id);


        IDataResult<CourseInstructor> GetById(int Id);


        IResult Add(CourseInstructor courseInstructor);
        IResult Update(CourseInstructor courseInstructor);
        IResult Delete(CourseInstructor courseInstructor);

    }
}

