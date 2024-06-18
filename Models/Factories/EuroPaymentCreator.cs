namespace TicketShop.Models.Factories
{
    //Subclass that implements factory method and creates object
    public class EuroPaymentCreator : PaymentCreator
    {
        public override PaymentMethod CreatePaymentMethod()
        {
            return new EuroPayment();
        }
    }
}
