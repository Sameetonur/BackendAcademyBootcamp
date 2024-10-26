using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Project08_ProtfolioApp.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }

    
}
