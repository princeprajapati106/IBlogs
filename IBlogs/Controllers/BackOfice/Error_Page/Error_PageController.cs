using Microsoft.AspNetCore.Mvc;

namespace IBlogs.Controllers.BackOfice.Error_Page
{
    public class Error_PageController : Controller
    {
        public IActionResult Error()
        {
            try
            {
                return View();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
