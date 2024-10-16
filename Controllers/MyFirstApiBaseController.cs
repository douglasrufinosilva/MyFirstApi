using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;
[Route("teste/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Douglas Rufino";

    [HttpGet("healthy")]
    public IActionResult healthy()
    {
        return Ok("Its working");
    }

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }

}
