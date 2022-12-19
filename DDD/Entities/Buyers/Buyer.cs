namespace DDD.Entities.Buyer
{
    public class Buyer: IBuyer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CardType CardType { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
