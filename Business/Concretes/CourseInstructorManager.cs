using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
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

        public List<CourseInstructor> GetAll()
        {
            return _courseInsturcter.GetAll();
        }

        public List<CourseInstructor> GetAllByCourseId(int id)
        {
            return _courseInsturcter.GetAll(p=>p.CourseId==id);
        }

        public List<CourseInstructor> GetAllByInstructorId(int id)
        {
            return _courseInsturcter.GetAll(p => p.InstructorId == id);
        }
    }
}
