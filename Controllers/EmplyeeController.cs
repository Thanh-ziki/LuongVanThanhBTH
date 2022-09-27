using Microsoft.AspNetCore.Mvc;
using DemoMVC.models;
namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            // tao 1 list Emplyee gồm 5 phần tử
            List<Employee> employeeVC = new List<Employee>()
            {
                new Employee {ID = 1, FullName ="Nhân Viên A"},
                new Employee {ID = 2, FullName ="Nhân Viên B"},
                new Employee {ID = 3, FullName ="Nhân Viên C"},

            };
            ViewData["Employee"] = employeeVC;
            return View();
        }
    }
}