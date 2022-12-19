namespace DDD.Entities.Buyer
{
    public class BuyerFactory : IBuyerFactory
    {
        public Buyer Create(int id, string name, CardType cardType, PaymentMethod paymentMethod)
        {
            return new Buyer()
            {
                Id = id,
                Name = name,
                CardType = cardType,
                PaymentMethod = paymentMethod
            };
        }
    }
}
