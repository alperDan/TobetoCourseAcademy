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
    public class InstructorManager: IInstructorService
    {
        IInstructorDal _instructor;

        public InstructorManager(IInstructorDal instructor)
        {
            _instructor = instructor;
        }

        public List<Instructor> GetAll()
        {
            return _instructor.GetAll();
        }

        public List<Instructor> GetById(int id)
        {
            return _instructor.GetAll(p=>p.Id==id);
        }

        public List<Instructor> GetByName(string name)
        {
            return _instructor.GetAll(p => p.Name == name);
        }


    }
}
