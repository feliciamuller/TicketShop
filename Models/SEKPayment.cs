namespace TicketShop.Models
{
    //Belongs to factory method pattern
    //Concrete class that implements method to process payment
    public class SEKPayment : PaymentMethod
    {
        public override string ProcessPayment(double amount)
        {
            return $"Du har betalat {amount} SEK.";
        }
    }
}
