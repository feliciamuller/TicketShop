namespace TicketShop.Models.Strategy
{
    //Concrete strategy for Student discount
    public class StudentDiscountStrategy : ITicketDiscountStrategy
    {
        private readonly double _studentDiscount = 200;

        public double AddDiscount(double price)
        {
            return price - _studentDiscount;
        }
    }
}
