using AnyCompany.Models;
using AnyCompany.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AnyCompany.Services
{
    public class CustomerService
    {
        public Customer CreateCustomer(Customer customer)
        {
            return CustomerRepository.CreateCustomer(customer);
        }

        public Customer GetCustomer(int CustomerId)
        {
            return CustomerRepository.GetCustomer(CustomerId);
        }

        public List<Customer> GetCustomers()
        {
            return CustomerRepository.GetAllCustomers();
        }

        public List<Customer> GetCustomersWithOrders()
        {
            var customers = CustomerRepository.GetAllCustomers();

            foreach(var customer in customers)
            {
                customer.Orders = OrderRepository.GetAllOrders(customer.CustomerId);
            }
            

            return customers;
        }
    }
}