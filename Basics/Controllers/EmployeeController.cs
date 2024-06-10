using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
          public IActionResult Index1()
          {
            string message = $"Hello world. {DateTime.Now.ToString()}";
            return View("Index1", message);
          }
          public ViewResult Index2()
          {
            var names = new String[]
            {
              "Bulut",
              "Ege",
              "Teoman"
            };
            return View(names );
          }
          public IActionResult Index3()
          {
            var list  = new List<Employee>()
            {
              new Employee(){Id=1,FirstName="Bulut",LastName="Mertkil",Age=1},
              new Employee(){Id=2,FirstName="Güneş",LastName="Mertkil",Age=3},
              new Employee(){Id=3,FirstName="Evrim",LastName="Mertkil",Age=5}
            };
            return View("Index3", list);
          }
    }
}
