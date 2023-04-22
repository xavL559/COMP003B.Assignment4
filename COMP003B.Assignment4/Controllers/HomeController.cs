using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP003B.Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationViewModel model)
        {
            if (ModelState.IsValid) 
            {

                ModelState.Clear();
            }
            return View();
        }
        
        public ActionResult _AboutTheOrganizer()
        {
            return PartialView("_AboutTheOrganizer");
        }

        
        public ActionResult ThankYou (string Name, string Email, long Phone, string Address) 
        {
            RegistrationViewModel b0bj = new RegistrationViewModel();
            b0bj.Name = Name;
            b0bj.Email = Email;
            b0bj.Phone = Phone;
            b0bj.Address = Address;

            return View(b0bj);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}