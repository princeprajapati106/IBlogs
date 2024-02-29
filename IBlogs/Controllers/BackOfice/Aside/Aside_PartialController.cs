using Microsoft.AspNetCore.Mvc;

namespace IBlogs.Controllers.BackOfice.Aside
{
    public class Aside_PartialController : Controller
    {
        public IActionResult SidePabal()
        {
            return PartialView("SidePabal");
        }
    }
}
