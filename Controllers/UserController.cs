using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers;

public class UserController : MyFirstApiBaseController
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetUserById([FromRoute] int id)
    {
        var response = new User
        {
            Id = 1,
            Name = "Douglas",
            Email = "Douglas@mail.com",
            Password = "12345"
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedUserJson), StatusCodes.Status201Created)]
    public IActionResult CreateUser([FromBody] RequestCreateUserJson request)
    {

        ResponseCreatedUserJson response = new ResponseCreatedUserJson
        {
            Id = request.Id,
            Name = request.Name
        };
        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateUser([FromBody] RequestUpdateUserJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteUser()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAllUsers()
    {
        List<User> users = new List<User>()
        {
            new User { Id = 2, Name = "Douglas", Email = "douglas@mail.com", Password = "12345" },
            new User { Id = 2, Name = "teste", Email = "teste@mail.com", Password = "1sf23sfg45" }
        };

        return Ok(users);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult UpdatePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }
}
