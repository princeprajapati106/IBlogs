using Microsoft.AspNetCore.Mvc;

namespace IBlogs.Controllers.Website.WebSiteLogin
{
    public class WebSite_LoginConstroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
