using Microsoft.AspNetCore.Mvc;

namespace EBBS_Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Signin()
        {
            HttpContext.Session.SetInt32("UserRole", 1);
            HttpContext.Session.SetInt32("UserId", 1);
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View();
        }
        public IActionResult ViewServiceNumber()
        {
            
            return View();
        }
        public IActionResult AAddServiceDetails()
        {

            return View();
        }
     
        public IActionResult Enterbill()
        {

            return View();
        }
        
    }
}
