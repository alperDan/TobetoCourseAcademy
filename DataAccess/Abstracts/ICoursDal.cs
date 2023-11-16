using System;
using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;

namespace DataAccess.Abstracts
{
	public interface ICoursDal: IEntityRepository<Course>
    {
		List<CourseDetailDto> GetCourseDetail();
	}
}

