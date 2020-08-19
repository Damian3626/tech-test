using AnyCompany.Models;
using AnyCompany.Providers;
using AnyCompany.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnyCompany.Repositories
{
    public class OrderRepositoryWrapper : IOrderRepository
    {
        public bool Save(Order order)
        {
            return OrderRepository.Save(order);
        }

        public List<Order> GetAllOrders(int customerId)
        {
            return OrderRepository.GetAllOrders(customerId);
        } 
    }
}
