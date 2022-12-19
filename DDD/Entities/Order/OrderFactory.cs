using System.Collections.Generic;

namespace DDD.Entities.Order
{
    public class OrderFactory : IOrderFactory
    {
        public Order Create(int id, OrderStatus status, List<Product> products, string address)
        {
            return new Order()
            {
                Id = id,
                Status = status,
                Products = products,
                Address = address
            };
        }
    }
}
