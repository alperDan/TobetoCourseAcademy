using System;
using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Order>> GetByCustomerId(int id)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p=>p.CustomerId==id), Messages.Listed);
        }

        public IDataResult<List<Order>> GetByOrderId(int id)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.OrderId == id), Messages.Listed);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new Result(true, Messages.Updated);
        }
    }
}

