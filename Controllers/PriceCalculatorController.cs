using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using TicketShop.Models;
using TicketShop.Models.Strategy;
using TicketShop.Models.ViewModel;

namespace TicketShop.Controllers
{
    public class PriceCalculatorController : Controller
    {
        //Declaring a ticket price
        double ticketPrice = 800;
        public IActionResult Index()
        {
            ViewData["TicketPrice"] = ticketPrice;
            return View();
        }

        //Calculating student discount
        public IActionResult StudentTicket()
        {
            var ticketPriceCalculator = new TicketPriceCalculator();
            ticketPriceCalculator.SetDiscountStrategy(new StudentDiscountStrategy());
            var totalAmount = ticketPriceCalculator.CalculateTicketPrice(ticketPrice);

            var model = new TicketPaymentViewModel
            {
                TotalAmount = totalAmount,
                TicketPriceCalculator = ticketPriceCalculator
            };
            //Serialize model object and save it in TempData
            TempData["TicketPayment"] = JsonConvert.SerializeObject(model);
       
            ViewData["TicketPrice"] = ticketPrice;
            ViewData["TotalAmount"] = totalAmount;
            return View("Index");
        }
        //Calculating senior discount
        public IActionResult SeniorTicket()
        {
            var ticketPriceCalculator = new TicketPriceCalculator();
            ticketPriceCalculator.SetDiscountStrategy(new SeniorDiscountStrategy());
            var totalAmount = ticketPriceCalculator.CalculateTicketPrice(ticketPrice);

            var model = new TicketPaymentViewModel
            {
                TotalAmount = totalAmount,
                TicketPriceCalculator = ticketPriceCalculator
            };

            TempData["TicketPayment"] = JsonConvert.SerializeObject(model);

            ViewData["TicketPrice"] = ticketPrice;
            ViewData["TotalAmount"] = totalAmount;
            return View("Index");
        }
        //Calculating youth discount
        public IActionResult YouthTicket()
        {
            var ticketPriceCalculator = new TicketPriceCalculator();
            ticketPriceCalculator.SetDiscountStrategy(new YouthDiscountStrategy());
            var totalAmount = ticketPriceCalculator.CalculateTicketPrice(ticketPrice);

            var model = new TicketPaymentViewModel
            {
                TotalAmount = totalAmount,
                TicketPriceCalculator = ticketPriceCalculator
            };

            TempData["TicketPayment"] = JsonConvert.SerializeObject(model);

            ViewData["TicketPrice"] = ticketPrice;
            ViewData["TotalAmount"] = totalAmount;
            return View("Index");
        }
        //Calculating no discount
        public IActionResult AdultTicket()
        {
            var ticketPriceCalculator = new TicketPriceCalculator();
            ticketPriceCalculator.SetDiscountStrategy(new NoDiscountStrategy());
            var totalAmount = ticketPriceCalculator.CalculateTicketPrice(ticketPrice);

            var model = new TicketPaymentViewModel
            {
                TotalAmount = totalAmount,
                TicketPriceCalculator = ticketPriceCalculator
            };

            TempData["TicketPayment"] = JsonConvert.SerializeObject(model);

            ViewData["TicketPrice"] = ticketPrice;
            ViewData["TotalAmount"] = totalAmount;
            return View("Index");
        }
    }
}
