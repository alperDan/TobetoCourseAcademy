using System;
using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface ICategoryService
	{
        IDataResult<List<Category>> GetAll();

        IDataResult<Category> GetById(int Id);

        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);

    }
}

