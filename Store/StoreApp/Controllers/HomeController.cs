using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Conrollers
{
    public class HomeController : Controller
    {
         public IActionResult Index(){
            return View();
         }
    }
}