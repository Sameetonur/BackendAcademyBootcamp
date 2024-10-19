using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project05_MVCTemelleri.Models;

namespace Project05_MVCTemelleri.Controllers;
    //controller isismlendirillirken mutlaka controller ifadesi ile bitmek zorundadır.
public class HomeController : Controller
{
   
    public  IActionResult About()
    {
        return View();
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
