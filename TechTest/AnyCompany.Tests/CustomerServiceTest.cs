using AnyCompany.Repositories.Interfaces;
using AnyCompany.Services;
using NUnit.Framework;

namespace AnyCompany.Tests
{
    [TestFixture]
    class CustomerServiceTest
    {

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TestGetCustomer(int customerId)
        {
            var customerService = new CustomerService();

            var customer = customerService.GetCustomer(customerId);

            Assert.AreEqual(customerId, customer.CustomerId);
        }

        [Test]
        public void TestGetCustomers()
        {
            var customerService = new CustomerService();

            var customers = customerService.GetCustomers();

            Assert.NotNull(customers);
        }

        [Test]
        public void TestGetCustomersWithOrders()
        {
            var customerService = new CustomerService();

            var customers = customerService.GetCustomersWithOrders();

            Assert.NotNull(customers);

        }
    }
}
