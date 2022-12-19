using DDD.Entities;
using DDD.Entities.Buyer;
using DDD.Entities.Order;
using System;
using System.Collections.Generic;

namespace DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsBueyerOne = new List<Product> { new ("Book", 550), 
                                                        new ("Hand cream", 250)};

            var productsBueyerTwo = new List<Product>() { new ("Salad", 220) };

            IBuyerFactory buyerFactory = new BuyerFactory();
            IOrderFactory orderFactory = new OrderFactory();
            IBuyerRepository buyerRepository = new BuyerRepository();
            IOrderRepository orderRepository = new OrderRepository();
            var buyerOne = buyerFactory.Create(1, "Anastasia", CardType.MIR, PaymentMethod.SberPay);
            var buyerTwo = buyerFactory.Create(2, "Alex", CardType.Visa, PaymentMethod.CreditCard);
            var orderOne = orderFactory.Create(1, OrderStatus.InProgress, productsBueyerOne, "Lyubertsy");
            var orderTwo = orderFactory.Create(2, OrderStatus.Completed, productsBueyerTwo, "Moscow");
            buyerRepository.Add(buyerOne);
            buyerRepository.Add(buyerTwo);
            orderRepository.Add(orderOne);
            orderRepository.Add(orderTwo);
            Console.WriteLine("Buyer one: " + buyerRepository.GetId(1).Name + "\nOrder status: " + orderRepository.GetId(1).Status + "\nOrder address: "+  orderRepository.GetId(1).Address);
            Console.WriteLine("\nBuyer two: " + buyerRepository.GetId(2).Name + "\nOrder status: " + orderRepository.GetId(2).Status + "\nOrder address: " + orderRepository.GetId(2).Address);

        }
    }
}
