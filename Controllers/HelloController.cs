using Microsoft.AspNetCore.Mvc;

namespace SayHelloEndpoints.Controllers;

[ApiController]
[Route("[controller]")]

public class HelloController : Controller
{
    public string text = "Hello, Jared";

    [HttpGet]
    [Route("Hello")]
    public string GetName()
    {
        return text;
    }

    [HttpPost]
    [Route("HelloName/{Name}")]
    public string AddName(string Name)
    {
        return "Hello, " + Name;
    }
}
