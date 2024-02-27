using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using react_native.Models;

namespace react_native.Controllers;

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

    public IActionResult Ulkeler()
    {
        string[ ] country ={
            "Azerbaycan",
            "Rusya",
            "Almanya",
        };
        ViewBag.countries=country;
        return View();

    }

    public IActionResult Cnr()
    {
        return View();
    }

    public IActionResult Time()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
