using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
namespace DemoMvc.Controllers;
public class PersonController : Controller
{
    public IActionResult Index()
    {
        List<Person> stdList= new List<Person>()
        {
            new Person {ID = "số", Password= 3, NickName = 36},
            new Person {ID = "dá", Password= 2, NickName = 75},
            new Person {ID = "dá", Password= 2, NickName = 75}
        };
        ViewData["Người Dùng"] = stdList;
        return View();
     }
     [HttpPost]
     public IActionResult Create(Person std)
    {   
        // string message = std.StudentID +"-";
        // message += std.StudentName + "-";
        // mesage += std.Age;
        // ViewBag.TT = message;
        return View();
    }

}