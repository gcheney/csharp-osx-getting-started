using System.Collections.Generic;

namespace DesignPatterns
{
    public interface IOrderRepository
    {
        Order GetById(int id);
        List<Order> List();
        void Add(Order order);
        void Update (Order order);
        void Delete (Order order);
    }
}