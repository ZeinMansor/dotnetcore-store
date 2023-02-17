using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BasicStoreDemo.Models;
using BasicStoreDemo.Util;
using BasicStoreDemo.ViewModels;

namespace BasicStoreDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DataContext context;

    public HomeController(ILogger<HomeController> logger, DataContext _context)
    {
        _logger = logger;
        context = _context;
    }

    public IActionResult Index()
    {

        bool notEmpty = context.Products.Any<Product>();
        if (notEmpty)
        {
            var products = context.Products.ToList<Product>();
            var result = new IndexViewModel { products = products };
            return View(result);
        }
        else
        {

            return View();
        }

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

