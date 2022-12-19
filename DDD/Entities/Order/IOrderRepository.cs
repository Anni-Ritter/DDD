using System.Collections.Generic;

namespace DDD.Entities.Order
{
    public interface IOrderRepository
    {
        void Add(Order order);
        Order GetId(int id);
        List<Order> GetAll();
        void Remove(int id);
        void Update(Order order);
    }
}
