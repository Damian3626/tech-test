using AnyCompany.Helpers;
using AnyCompany.Models;
using AnyCompany.Repositories;
using System.Collections.Generic;

namespace AnyCompany.Services
{
    public class OrderService
    {
        public bool PlaceOrder(Order order, int customerId)
        {
            if (!OrderAmountHelper.OrderAmountValid(order.Amount))
            {
                // Add logging here in this case
                return false;
            }

            var customer = CustomerRepository.GetCustomer(customerId);

            if (customer == null)
            {
                // Add logging here in this case
                return false;
            }
            else
            {
                order.VAT = OrderAmountHelper.VATAmount(customer.Country);
            }
            return OrderRepository.Save(order);
        }
    }
}
