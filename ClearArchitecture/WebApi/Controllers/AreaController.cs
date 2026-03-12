using Application.Command.Area;
using Application.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddAreaAsync(
          [FromBody] AreaEntities area)
        {
            var result = await sender.Send(new AddAreaCommand(area));
            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAreaAsync()
        {
            var result = await sender.Send(new GetAllAreaQueries());
            return Ok(result);
        }

    }
}
