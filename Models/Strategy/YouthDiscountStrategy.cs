namespace TicketShop.Models.Strategy
{
    //Concrete strategy for Youth discount
    public class YouthDiscountStrategy : ITicketDiscountStrategy
    {
        private readonly double _youthDiscount = 150;
        public double AddDiscount(double price)
        {
            return price - _youthDiscount;
        }
    }
}
