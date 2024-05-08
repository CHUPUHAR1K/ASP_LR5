using Microsoft.AspNetCore.Mvc;

namespace ASP_LR5.Controllers
{
  
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        }
}
