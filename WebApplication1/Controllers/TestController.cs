using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        
        public ActionResult GetView()
        {

            Employee emp = new Employee();

            emp.FirstName = "Lina";
            emp.LastName = "Pinilla";
            emp.Salary = 800000;

            ViewData["Employee"] = emp;
            return View("MyView");

        }

    }
}