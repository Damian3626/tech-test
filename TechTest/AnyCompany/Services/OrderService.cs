using AnyCompany.Helpers;
using AnyCompany.Models;
using AnyCompany.Repositories;

namespace AnyCompany.Services
{
    public class OrderService
    {
        private readonly OrderRepository orderRepository = new OrderRepository();

        public bool PlaceOrder(Order order, int customerId)
        {
            Customer customer = CustomerRepository.Load(customerId);

            if (OrderAmountHelper.OrderAmountValid(order.Amount))
                return false;

            if(customer == null)
            {

            }
            else
            {
                order.VAT = OrderAmountHelper.VATAmount(customer.Country);
            }

            return orderRepository.Save(order);
        }
    }
}
