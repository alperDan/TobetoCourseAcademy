using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal : EfEntityRepositoryBase<Course, TobetoContext>, ICoursDal
    {
        public List<CourseDetailDto> GetCourseDetail()
        {
            using (TobetoContext context=new TobetoContext())
            {
                var resut = from p in context.Courses
                            join c in context.Categorys
                            on p.CategoryId equals c.CategoryId
                            select new CourseDetailDto
                            {
                                CourseId = p.Id,
                                CourseName = p.CourseName,
                                CategoryName = c.CategoryName,
                               
                                //UnitsInStock=.UnitsInStock
                            };

                return resut.ToList();

            }
        }
    }
}
