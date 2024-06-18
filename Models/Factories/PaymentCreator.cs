namespace TicketShop.Models.Factories
{
    //Factory method pattern
    public abstract class PaymentCreator
    {
        //Factory method that subclasses implements to create objects
        public abstract PaymentMethod CreatePaymentMethod();
        public string ProcessPayment(double amount)
        {
            var paymentMethod = CreatePaymentMethod();
            return paymentMethod.ProcessPayment(amount);
        }
    }
}
