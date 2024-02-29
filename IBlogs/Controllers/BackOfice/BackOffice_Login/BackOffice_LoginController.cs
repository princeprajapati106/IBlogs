using IBlogs.Models.Login;
using Microsoft.AspNetCore.Mvc;

namespace IBlogs.Controllers.BackOfice.BackOffice_Login
{
    public class BackOffice_LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login_User(LoginCredentials _Credentials)
        {
            try
            {
                return View();
            }
            catch (Exception Ex)
            {
                TempData["ErrorMessage"] = Ex.Message.ToString();
                TempData.Keep();
                return RedirectToAction("Error", "Error_Page");
            }

        }
    }
}
