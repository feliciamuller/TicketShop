namespace TicketShop.Models.Strategy
{
    //Concrete strategy for no discount
    public class NoDiscountStrategy : ITicketDiscountStrategy
    {
        public double AddDiscount(double price)
        {
            return price;
        }
    }
}
