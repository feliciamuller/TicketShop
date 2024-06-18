namespace TicketShop.Models.ViewModel
{
    public class TicketPaymentViewModel
    {
        public double TotalAmount { get; set; }
        public TicketPriceCalculator TicketPriceCalculator { get; set; }
    }
}
