using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;
using BlogApp.Data;

namespace BlogApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IManager<Personel> personel;
    private readonly IManager<Skill> skill;

    private readonly IManager<Social> social;

    public HomeController(ILogger<HomeController> logger, IManager<Personel> personel, IManager<Social> social, IManager<Skill> skill)
    {
        _logger = logger;
        this.personel = personel;
        this.social = social;
        this.skill = skill;
    }

    public IActionResult Index()
    {
      var personels=  personel.GetAll().First();
    var socials=social.GetAll();
    var Skills=skill.GetAll();
    personels.Skills=Skills;
    personels.Socials=socials;

        return View(personels);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
