using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TicketShop.Models.Factories;
using TicketShop.Models.ViewModel;

namespace TicketShop.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessPayment(string currencyType)
        {
            //Using TempData and checking condition if its serialized and save it in variable
            if (TempData["TicketPayment"] is string modelJson)
            {
                //Deserialize string to object and save it in a variable
                var paymentInfo = JsonConvert.DeserializeObject<TicketPaymentViewModel>(modelJson);

                PaymentCreator paymentCreator;
                string paymentMessage;

                if (currencyType == "Euro")
                {
                    paymentCreator = new EuroPaymentCreator();
                }
                else if (currencyType == "SEK")
                {
                    paymentCreator = new SEKPaymentCreator();
                }
                else
                {
                    return BadRequest("Felaktig valuta");
                }

                ViewData["TotalAmount"] = paymentInfo.TotalAmount;
                paymentMessage = paymentCreator.ProcessPayment(paymentInfo.TotalAmount);
                return View("ProcessPayment", paymentMessage);
            }
            //If TempData is not serialized
            return BadRequest("Betalning misslyckades");
        }
    }
}
