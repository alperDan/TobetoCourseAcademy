using System;
using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts
{
	public interface ICourseService
	{
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetByCategoryId(int id);
        IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<Course>> GetByCourseName(string name);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();

        IResult Add(Course course);

        IDataResult<Course> GetById(int Id);
    }
}

