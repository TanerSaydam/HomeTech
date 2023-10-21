using ExampleWebMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExampleWebMvc.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Product _product;
    private readonly IService _service;
    public HomeController(ILogger<HomeController> logger, Product product, IService service)
    {
        _logger = logger;
        _product = product;
        _service = service;
    }

    public IActionResult Index()
    {
        int a = 0;
        int b = 0;
        int c = a / b;
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
