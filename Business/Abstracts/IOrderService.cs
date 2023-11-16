using System;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface IOrderService
	{
        List<Order> GetAll();
        List<Order> GetByCustomerId(int id);
        List<Order> GetByOrderId(int id);
        //List<Order> GetByEmployeeId(int id);
    }
}

