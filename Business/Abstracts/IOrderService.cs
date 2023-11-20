using System;
using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface IOrderService
	{
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetByCustomerId(int id);
        IDataResult<List<Order>> GetByOrderId(int id);
        //IDataResult<List<Order>> GetByEmployeeId(int id);

        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    }
}

