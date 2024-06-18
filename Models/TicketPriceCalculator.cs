using TicketShop.Models.Strategy;

namespace TicketShop.Models
{
    //Context class that uses strategy interface
    public class TicketPriceCalculator
    {
        public double Price { get; set; }

        //Reference to interface
        private ITicketDiscountStrategy _ticketDiscount;

        //Method to set discount
        public void SetDiscountStrategy(ITicketDiscountStrategy ticketDiscount)
        {
            _ticketDiscount = ticketDiscount;
        }
        //Method that calculates price
        public double CalculateTicketPrice(double price)
        {
            Price = price;
            return _ticketDiscount.AddDiscount(price);
        }
    }
}
