using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using simple_backend.Models;

namespace simple_backend.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var posts = new List<BlogPostModel>();

        posts.Add(new BlogPostModel
        {
            Title = "npm audit: Broken by Design",
            CreatedDate = new DateTime(2021, 7, 7),
            Description = "Found 99 vulnerabilities (84 moderately irrelevant, 15 highly irrelevant)"
        });

        posts.Add(new BlogPostModel
        {
            Title = "Before You memo()",
            CreatedDate = new DateTime(2021, 2, 23),
            Description = "Rendering optimizations that come naturally."
        });

        posts.Add(new BlogPostModel
        {
            Title = "The WET Codebase",
            CreatedDate = new DateTime(2020, 7, 13),
            Description = "Come waste your time with me."
        });

        return View(posts);
    }

    public IActionResult Harry()
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
