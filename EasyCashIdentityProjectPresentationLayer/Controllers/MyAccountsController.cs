using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProjectPresentationLayer.Controllers
{
    public class MyAccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
