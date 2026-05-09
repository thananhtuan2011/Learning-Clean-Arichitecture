using Application.Command.Area;
using Application.Command.User;
using Application.DTO;
using Application.Queries.User;
using Domain.Entities;
using Domain.Entities.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(ISender sender) : ControllerBase
    {
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserEntities user)
        {
            var result = await sender.Send(new RegisterUserCommand(user));
            return Ok(result);
        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] RequestLoginDTO data)
        {
            var result = await sender.Send(new LoginQueries(data));
            return Ok(result);
        }
    }
}
