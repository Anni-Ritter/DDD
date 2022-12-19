namespace DDD.Entities.Buyer
{
    public interface IBuyerFactory
    {
        public Buyer Create(int id, string name, CardType cardType, PaymentMethod paymentMethod);
    }
}
