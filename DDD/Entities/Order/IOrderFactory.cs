using System.Collections.Generic;

namespace DDD.Entities.Order
{
    public interface IOrderFactory
    {
        public Order Create(int id, OrderStatus status, List<Product> products, string address);
    }
}
