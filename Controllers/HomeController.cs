using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarsListWeb.Models;

namespace CarsListWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppSettings _appSettings;

    public HomeController(ILogger<HomeController> logger, AppSettings appSettings)
    {
        _logger = logger;
        _appSettings = appSettings;
    }

    public IActionResult Index()
    {
        return View();
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
