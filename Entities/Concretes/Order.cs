using System;
using Core.Entities;

namespace Entities.Concretes
{
	public class Order:IEntity
	{
		public int OrderId { get; set; }
		public int CustomerId { get; set; }
		public DateTime OrderDate { get; set; }
		public string ShipCity { get; set; }

		//public int CourseId { get; set; }
		//public Course course { get; set; }




    }
}

