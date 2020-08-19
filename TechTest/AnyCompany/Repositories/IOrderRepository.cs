using AnyCompany.Models;

namespace AnyCompany.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        bool Save(Order order);
    }
}