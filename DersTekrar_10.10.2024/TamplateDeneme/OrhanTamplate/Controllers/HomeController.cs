using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OrhanTamplate.Models;

namespace OrhanTamplate.Controllers;

public class HomeController : Controller
{
    

    

    public IActionResult Index()
    {
        return View();
    }

   
}
