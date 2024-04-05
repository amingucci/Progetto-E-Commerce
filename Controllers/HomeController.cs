using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using galli.mingucci._5i.Progetto_E_Commerce.Models;

namespace galli.mingucci._5i.Progetto_E_Commerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        /*string? nomeUtente = HttpContext.Session.GetString("NomeUtente");
        if(string.IsNullOrEmpty(nomeUtente))
            return Redirect("\\home\\SignUp");*/
        return View();
    }

    [HttpGet]
    public IActionResult  SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult  SignUp(User u)
    {
        return View(u);
    }

    
    [HttpGet]
    public IActionResult  Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult  Login(Login l)
    {
        return View(l);
    }

     [HttpGet]
    public IActionResult  Bike()
    {
        return View();
    }

    [HttpPost]
    public IActionResult  Bike(Bike m)
    {
        return View(m);
    }

    [HttpGet]

    public IActionResult About()
    {
        return View();
    }

    [HttpGet]

    public IActionResult Cart()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Cart(Prenotation p)
    {
        return View(p);
    }

    [HttpPost]

    /*public IActionResult Confirm(User u)
    {
        /*if( u != null && u.Name != null)
        {
             HttpContext.Session.SetString("NomeUtente", u.Name);
             ViewData["NomeUtente"] = u.Name;
            //users.Add(u);
            return View(u);
        }
    }*/

    [HttpPost]
    public IActionResult Confirm(User u)
    {
        return View(u);
    }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
