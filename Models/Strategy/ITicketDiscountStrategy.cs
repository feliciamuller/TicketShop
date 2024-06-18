namespace TicketShop.Models.Strategy
{
    //Strategy interface
    public interface ITicketDiscountStrategy
    {
        double AddDiscount(double price);
    }
}
