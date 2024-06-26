using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace angulardotnet.Controllers;

public class HelloWorldController : Controller
{
    //
    // GET: /HelloWorld/
    public ActionResult Index()
    {
        return View();
    }
    //
    // GET: /HelloWorld/Welcome/
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}

