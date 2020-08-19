using AnyCompany.Models;
using AnyCompany.Providers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnyCompany.Repositories
{
    public class OrderRepository
    {
        public static bool Save(Order order)
        {
            try
            {
                using (DbProvider dbProvider = new DbProvider())
                {
                    dbProvider.Orders.Add(order);
                    dbProvider.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                // Add logging here in this case
            }

            return false;
        }

        public static List<Order> GetAllOrders(int customerId)
        {
            try
            {
                using (DbProvider dbProvider = new DbProvider())
                {
                    return dbProvider.Orders.Where(x => x.CustomerId == customerId).ToList();
                }
            }
            catch (Exception ex)
            {
                // Add logging here in this case
            }

            return null;
        }
    }
}
