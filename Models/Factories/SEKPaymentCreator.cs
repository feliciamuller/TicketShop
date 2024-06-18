namespace TicketShop.Models.Factories
{
    //Subclass that implements factory method and creates object
    public class SEKPaymentCreator : PaymentCreator
    {
        public override PaymentMethod CreatePaymentMethod()
        {
            return new SEKPayment();
        }
    }
}
