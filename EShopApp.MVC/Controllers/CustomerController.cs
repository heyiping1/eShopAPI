using Microsoft.AspNetCore.Mvc;

namespace EShop.MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
