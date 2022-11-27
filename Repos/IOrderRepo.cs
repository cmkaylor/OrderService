using System.Collections.Generic;
using OrderService.Models;

namespace OrderService.Repos
{
    public interface IOrderRepo
    {
        bool SaveChanges();
        IEnumerable<Order> GetOrders(int businessID);
        void CreateOrder(Order order);
    }
}