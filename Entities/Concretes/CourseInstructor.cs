using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concretes
{
    public class CourseInstructor:IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public Course course { get; set; }
        public Instructor instructor { get; set; }


    }
}
