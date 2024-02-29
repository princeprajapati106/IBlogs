using Microsoft.AspNetCore.Mvc;

namespace IBlogs.Controllers.BackOfice.DashBoard
{
    public class DashBoardController : Controller
    {
        public IActionResult DashBoard_Main()
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
