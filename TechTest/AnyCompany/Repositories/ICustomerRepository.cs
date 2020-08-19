using AnyCompany.Models;
using System.Collections.Generic;

namespace AnyCompany.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Customer CreateCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetCustomer(int customerId);
    }
}