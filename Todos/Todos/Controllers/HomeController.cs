using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Todos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        //JsonResult json=new JsonResult(new { 
        //Name="Naciba",
        //Surname="Rasulova"
        //});
        //ContentResult result=new ContentResult();
        //    result.Content = "<h1>Home</h1>";
        //    result.ContentType= "text/txt";
        //ViewData["name"] = "Naciba";
        //ViewData["surname"] = "Rasulova";
        List<string> names = ["Naciba", "Sumaya", "Nigar", "Fidan", "Rafiga", "Selcan","Jala"];
        ViewData["names"] = names;
        return View();
    }
    public IActionResult Details()
    {
        TempData["Other"] = "Detailden salamlar";
        ViewData["Otherview"] = "Detailden salamlar";
        return RedirectToAction(nameof(Index));
    }
    public string Hi(string name,int num)
    {   
        return name + " " + num;
    }
    public int? Murad(int? id)
    { 
       return id;
    }
}
