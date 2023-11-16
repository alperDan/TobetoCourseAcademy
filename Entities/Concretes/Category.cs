using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concretes
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual List<Course> Courses { get; set; }
    }
}
