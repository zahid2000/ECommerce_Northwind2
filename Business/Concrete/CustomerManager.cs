﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetAll()
        {
          return  _customerDal.GetAll();
            
        }

        public Customer GetById(string customerId)
        {
          return  _customerDal.GetAll().SingleOrDefault(c => c.CustomerId == customerId);
        }
    }
}
