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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            if (category.CategoryName.Length < 2)
            {
                return new ErrorResult(Messages.NameInValid);
            }
            _categoryDal.Add(category);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Category>>(Messages.MaintenanaceTime);
            }
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Category> GetById(int Id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == Id));
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new Result(true, Messages.Updated);
        }

        
    }
}
