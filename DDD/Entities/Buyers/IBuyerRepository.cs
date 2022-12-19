using System.Collections.Generic;

namespace DDD.Entities.Buyer
{
    public interface IBuyerRepository
    {
        void Add(IBuyer buyer);
        IBuyer GetId(int id);
        List<IBuyer> GetAll();
        void Remove(int id);
        void Update(IBuyer buyer);
    }
}
