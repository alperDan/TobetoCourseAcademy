using System;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface IInstructorService
	{
        List<Instructor> GetAll();
        List<Instructor> GetById(int id);
        List<Instructor> GetByName(string name);
       
    }
}

