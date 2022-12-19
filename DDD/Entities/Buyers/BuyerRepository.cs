using DDD.Entities.Buyer;
using System;
using System.Collections.Generic;

namespace DDD.Entities
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly List<IBuyer> buyers = new();
        
        public void Add(IBuyer buyer)
        {
            buyers.Add(buyer);
        }

        public List<IBuyer> GetAll()
        {
            return buyers;
        }

        public IBuyer GetId(int id)
        {
            return buyers.Find(x => x.Id == id);
        }

        public void Remove(int id)
        {
            var removeId = buyers.Find(x => x.Id == id);

            if (removeId != null)
                buyers.Remove(removeId);
            else
                Console.WriteLine("Buyer's Id not find");
        }

        public void Update(IBuyer buyer)
        {
            var updateId = buyers.Find(x => x.Id == buyer.Id);

            if (updateId != null)
            {
                buyers.Remove(updateId);
                buyers.Add(buyer);
            }
            else
                Console.WriteLine("Buyer not find");
        }
    }
}
