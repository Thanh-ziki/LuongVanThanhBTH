using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
namespace DemoMvc.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {        
        List<Student> stdList=new List<Student>()
        {
            new Student {StudentID=1, StudentName="Nguyen Van A", Age=20},
            new Student {StudentID=2, StudentName="Nguyen Van B", Age=28},
            new Student {StudentID=3, StudentName="Nguyen Van C", Age=25},
            new Student {StudentID=4, StudentName="Nguyen Van D", Age=22},
            new Student {StudentID=5, StudentName="Nguyen Van E", Age=21},
            new Student {StudentID=6, StudentName="Nguyen Van F", Age=23},
        };
        ViewData["Student"] = stdList;
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student std)
    {
        // string message = std.StudentID +"-";
        // message += std.StudentName + "-";
        // mesage += std.Age;
        // ViewBag.TT = message;
        return View();
    }
}