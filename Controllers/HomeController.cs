namespace SimuladoIronFit.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace IronFit.Controllers
    {
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        }
    }
}
