using AnyCompany.Models;
using System.Collections.Generic;

namespace AnyCompany.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        bool Save(Order order);
        List<Order> GetAllOrders(int customerId);
    }
}