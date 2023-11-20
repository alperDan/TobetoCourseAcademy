using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICoursDal _courseDal;

        public CourseManager(ICoursDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            if (course.CourseName.Length<2)
            {
                return new ErrorResult(Messages.NameInValid);
            }
            _courseDal.Add(course);
            return new Result(true,Messages.Added);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Course>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanaceTime);
            }
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<Course>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p=>p.CategoryId==id));
        }

        public IDataResult<List<Course>> GetByCourseName(string name)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.CourseName == name));
        }

        public IDataResult<Course> GetById(int Id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(p=>p.Id==Id));
        }

        public IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p=>p.UnitPrice>=min&&p.UnitPrice<=max));
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetail());
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.Updated);
        }
    }
}
