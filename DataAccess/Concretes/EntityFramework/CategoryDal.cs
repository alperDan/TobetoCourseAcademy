using System;
using System.Linq.Expressions;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class CategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            using (TobetoContext context = new TobetoContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (TobetoContext context = new TobetoContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (TobetoContext context = new TobetoContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using (TobetoContext context = new TobetoContext())
            {
                return filter == null
                    ? context.Set<Category>().ToList()
                    : context.Set<Category>().Where(filter).ToList();

            }
        }

        public void Update(Category entity)
        {
            using (TobetoContext context = new TobetoContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }

}