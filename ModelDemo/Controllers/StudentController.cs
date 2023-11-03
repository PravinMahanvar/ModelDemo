using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddEmployee(Student student)
        {
            return View();
        }
    }
}
