using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;
[Route("teste/[controller]")]
[ApiController]
public class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Douglas Rufino";
}
