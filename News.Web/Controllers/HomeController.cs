using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using News.Core;
using News.Web.Models;

namespace News.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index(string? categories)
    {
        var client = new NewsClient();
        var news = await client.GetNews(string.Join(",", categories));

        return View(news);
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
