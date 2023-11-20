using System;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class CategoryDal : EfEntityRepositoryBase<Category, TobetoContext>, ICategoryDal
    {
        
    }

}