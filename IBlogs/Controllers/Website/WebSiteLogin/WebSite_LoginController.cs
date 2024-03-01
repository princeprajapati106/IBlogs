using Microsoft.AspNetCore.Mvc;

namespace IBlogs.Controllers.Website.WebSiteLogin
{
    public class WebSite_LoginConstroller : Controller
    {
        public IActionResult Index()
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
