using AnyCompany.Models;
using System.Configuration;
using System.Data.Entity;

namespace AnyCompany.Providers
{
    public class DbProvider : DbContext
    {
        public DbProvider() : base(ConfigurationManager.ConnectionStrings["CompanyConnection"].ConnectionString)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}