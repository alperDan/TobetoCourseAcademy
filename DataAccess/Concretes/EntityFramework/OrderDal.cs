﻿using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
	public class OrderDal: EfEntityRepositoryBase<Order, TobetoContext>, IOrderDal
    {
		
	}
}

