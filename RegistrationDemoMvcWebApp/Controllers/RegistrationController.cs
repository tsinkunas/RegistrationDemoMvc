using Microsoft.AspNetCore.Mvc;
using RegistrationDemoMvcWebApp.Models;

namespace RegistrationDemoMvcWebApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Post(RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Name = null;
                model.Age = null;
                model.Email = null;
            }
            return View("Index", model);
        }
    }
}
