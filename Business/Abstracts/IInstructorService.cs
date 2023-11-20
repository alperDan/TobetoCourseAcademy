using System;
using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface IInstructorService
	{
        IDataResult<List<Instructor>> GetAll();
        IDataResult<Instructor> GetById(int id);
        IDataResult<List<Instructor>> GetByName(string name);

        
        IResult Add(Instructor instructor);
        IResult Update(Instructor instructor);
        IResult Delete(Instructor instructor);

    }
}

