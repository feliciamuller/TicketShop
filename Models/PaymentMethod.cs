namespace TicketShop.Models
{
    //Belongs to factory method pattern
    //Abstract class and method
    public abstract class PaymentMethod
    {
        public abstract string ProcessPayment(double amount);
    }
}
