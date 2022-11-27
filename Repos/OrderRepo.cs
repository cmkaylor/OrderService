using System.Collections.Generic;
using System.Linq;
using OrderService.Data;
using OrderService.Models;

namespace OrderService.Repos
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _context;
        public OrderRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
        }

        public IEnumerable<Order> GetOrders(int businessID)
        {
            return _context.Orders.Where(o => o.Business.ID == businessID);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}