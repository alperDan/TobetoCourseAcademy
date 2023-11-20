using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Instructor instructor)
        {

            _instructor.Add(instructor);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Instructor instructor)
        {
            _instructor.Delete(instructor);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructor.GetAll(), Messages.Listed);
        }

        public IDataResult<Instructor> GetById(int id)
        {
            return new SuccessDataResult<Instructor>(_instructor.Get(p => p.Id == id));
        }

        public IDataResult<List<Instructor>> GetByName(string name)
        {
            return new SuccessDataResult<List<Instructor>>(_instructor.GetAll(p => p.Name == name));
        }

        public IResult Update(Instructor instructor)
        {
            _instructor.Update(instructor);
            return new Result(true, Messages.Updated);
        }
    }
}
