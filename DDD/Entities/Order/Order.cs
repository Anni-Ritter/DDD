using System.Collections.Generic;

namespace DDD.Entities.Order
{
    public class Order
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        public List<Product> Products { get; set; }
        public string Address { get; set; }
    }
}
