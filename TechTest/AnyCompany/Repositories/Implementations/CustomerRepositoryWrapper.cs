using AnyCompany.Models;
using AnyCompany.Repositories.Interfaces;
using System.Collections.Generic;

namespace AnyCompany.Repositories
{
    public class CustomerRepositoryWrapper : ICustomerRepository
    {
        public Customer GetCustomer(int CustomerId)
        {
            return CustomerRepository.GetCustomer(CustomerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return CustomerRepository.GetAllCustomers();
        }

        public Customer CreateCustomer(Customer customer)
        {
            return CustomerRepository.CreateCustomer(customer);
        }
    }
}