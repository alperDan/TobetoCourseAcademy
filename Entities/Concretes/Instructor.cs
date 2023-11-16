using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concretes
{
    public class Instructor:IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }

        public virtual List<Course> Courses { get; set; }
    }
}
