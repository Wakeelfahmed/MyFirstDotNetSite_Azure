using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApplication1
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitForm(string name, string email)
        {
            // Do something with the form data (e.g. save it to a database)
            // ...

            Debug.WriteLine("Hit");
            // Return a success message or redirect the user to a thank-you page
            return View("Success");
        }
        [HttpPost]
        public IActionResult SubmitForm()
        {
            Debug.WriteLine("Hit");

            // handle form submission here
            return Content("Success");
        }
    }
}
