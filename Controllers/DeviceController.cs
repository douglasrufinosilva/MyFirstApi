using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public IActionResult Get()
    {
        var laptop = new Laptop();

        var model = laptop.GetModel();

        return Ok(model);
    }
}
