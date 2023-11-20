using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseInstructorManager : ICourseInstructorService
    {
        ICourseInstructorDal _courseInsturcter;

        public CourseInstructorManager(ICourseInstructorDal courseInsturcter)
        {
            _courseInsturcter = courseInsturcter;
        }

        public IResult Add(CourseInstructor courseInstructor)
        {

            _courseInsturcter.Add(courseInstructor);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(CourseInstructor courseInstructor)
        {
            _courseInsturcter.Delete(courseInstructor);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<CourseInstructor>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<CourseInstructor>>(Messages.MaintenanaceTime);
            }
            return new SuccessDataResult<List<CourseInstructor>>(_courseInsturcter.GetAll(), Messages.Listed);
        }

        public IDataResult<List<CourseInstructor>> GetAllByCourseId(int id)
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInsturcter.GetAll(p=>p.CourseId==id), Messages.Listed);
        }

        public IDataResult<List<CourseInstructor>> GetAllByInstructorId(int id)
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInsturcter.GetAll(p => p.InstructorId == id), Messages.Listed);
        }

        public IDataResult<CourseInstructor> GetById(int Id)
        {
            return new SuccessDataResult<CourseInstructor>(_courseInsturcter.Get(p => p.Id == Id), Messages.Listed);
        }

        public IResult Update(CourseInstructor courseInstructor)
        {
            _courseInsturcter.Update(courseInstructor);
            return new Result(true, Messages.Updated);
        }
    }
}
