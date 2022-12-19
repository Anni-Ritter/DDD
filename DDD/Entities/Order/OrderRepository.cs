using System;
using System.Collections.Generic;

namespace DDD.Entities.Order
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> orders = new();

        public void Add(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetAll()
        {
            return orders;
        }

        public Order GetId(int id)
        {
            return orders.Find(x => x.Id == id);
        }

        public void Remove(int id)
        {
            var removeId = orders.Find(x => x.Id == id);

            if (removeId != null)
                orders.Remove(removeId);
            else
                Console.WriteLine("Order's Id not find");
        }

        public void Update(Order order)
        {
            var updateId = orders.Find(x => x.Id == order.Id);

            if (updateId != null)
            {
                orders.Remove(updateId);
                orders.Add(order);
            }
            else
                Console.WriteLine("Oder not find");
        }        
    }
}
