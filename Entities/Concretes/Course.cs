using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concretes
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public int UnitPrice { get; set; }

        public virtual List<Instructor> Instructors { get; set; } 
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
