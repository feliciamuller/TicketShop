namespace TicketShop.Models.Strategy
{
    //Concrete strategy for Senior discount
    public class SeniorDiscountStrategy : ITicketDiscountStrategy
    {
        private readonly double _seniorDiscount = 250;
        public double AddDiscount(double price)
        {
            return price - _seniorDiscount;
        }
    }
}
