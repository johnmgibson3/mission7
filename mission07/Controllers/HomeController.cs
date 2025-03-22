using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mission07.Models;

namespace mission07.Controllers;

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

    public IActionResult Joel()
    {
        return View();
    }
    public IActionResult Movie()
    {
        return View();
    }

    public IActionResult Collection()
    {
        return View();
    }
    

}