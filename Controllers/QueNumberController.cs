using Microsoft.AspNetCore.Mvc;
using TicketShop.Models.Service;

namespace TicketShop.Controllers
{
    public class QueNumberController : Controller
    {
        private readonly IQueNumber _queNumber;
        public QueNumberController(IQueNumber queNumber)
        {
            _queNumber = queNumber;
        }
        public IActionResult Index()
        {
            //Sets a random que number
            Random random = new Random();
            int randomNumber = random.Next(1, 25);
            if (_queNumber.GetQueNumber() == 0)
            {
                _queNumber.SetQueNumber(randomNumber);

            }
            //Gets the quenumber and save it in a variable
            var queNumber = _queNumber.GetQueNumber();
            //Sending the variable to view
            ViewData["QueNumber"] = queNumber;
            return View();
        }
    }
}
