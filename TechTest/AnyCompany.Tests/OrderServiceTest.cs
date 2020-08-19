using AnyCompany.Repositories.Interfaces;
using AnyCompany.Models;
using AnyCompany.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AnyCompany.Tests
{
    [TestFixture]
    public class OrderServiceTests
    {

        [Test]
        public void TestPlaceOrderValid()
        {
            var orderService = new OrderService();
            var customerService = new CustomerService();

            var customer = new Customer
            {
                Country = "US",
                DateOfBirth = DateTime.Now.AddYears(-35),
                Name = "John Bob"
            };

            var newCustomer = customerService.CreateCustomer(customer);

            var order = new Order
            {
                Amount = 300,
                CustomerId = newCustomer.CustomerId
            };

            var newOrder = orderService.PlaceOrder(order, newCustomer.CustomerId);

            Assert.IsTrue(newOrder, "Order was placed successfully");
        }

        [Test]
        public void TestPlaceOrderInValid()
        {
            var orderService = new OrderService();
            var customerService = new CustomerService();

            var customer = customerService.GetCustomer(1);

            var order = new Order
            {
                Amount = 0,
                CustomerId = customer.CustomerId
            };

            var newOrder = orderService.PlaceOrder(order, customer.CustomerId);

            Assert.IsFalse(newOrder, "Order failed successfully");
        }

        [Test]
        public void TestPlaceOrderUKVAT()
        {
            var orderService = new OrderService();
            var customerService = new CustomerService();

            var customer = customerService.GetCustomer(1);

            var order = new Order
            {
                Amount = 500,
                CustomerId = customer.CustomerId
            };

            var newOrder = orderService.PlaceOrder(order, customer.CustomerId);

            Assert.IsTrue(newOrder, "Order was placed successfully");
        }
    }
}
