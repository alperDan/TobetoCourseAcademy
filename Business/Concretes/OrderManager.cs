using System;
using Business.Abstracts;
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

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public List<Order> GetByCustomerId(int id)
        {
            return _orderDal.GetAll(p=>p.CustomerId==id);
        }

        public List<Order> GetByOrderId(int id)
        {
            return _orderDal.GetAll(p => p.OrderId == id);
        }
    }
}

