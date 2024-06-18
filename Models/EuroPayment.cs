namespace TicketShop.Models
{
    //Belongs to factory method pattern
    //Concrete class that implements method to process payment
    public class EuroPayment : PaymentMethod
    {
        public override string ProcessPayment(double amount)
        {
            double euroAmount = amount * 0.089;
            return $"Du har betalat {Math.Round(euroAmount, 2)} euro.";
        }
    }
}
