using AnyCompany.Models;
using AnyCompany.Providers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AnyCompany.Repositories
{
    public static class CustomerRepository
    {
        public static Customer CreateCustomer(Customer customer)
        {
            try
            {
                using (DbProvider dbProvider = new DbProvider())
                {
                    dbProvider.Customers.Add(customer);;
                    dbProvider.SaveChanges();

                    return dbProvider.Customers.First(x => x.CustomerId == customer.CustomerId) ?? null;
                }
            }
            catch (Exception ex)
            {
                // Add logging here in this case
            }

            return null;
        }

        public static List<Customer> GetAllCustomers()
        {
            try
            {
                using (DbProvider dbProvider = new DbProvider())
                {
                    return dbProvider.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                // Add logging here in this case
            }

            return null;
        }

        public static Customer GetCustomer(int customerId)
        {

            try
            {
                using (DbProvider dbProvider = new DbProvider())
                {
                    return dbProvider.Customers.First(x => x.CustomerId == customerId) ?? null;
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
