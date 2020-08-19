using AnyCompany.Models;

namespace AnyCompany.Repositories
{
    public interface ICustomerRepository
    {
        Customer Load(int customerId);
    }
}