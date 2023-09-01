using Application.Feautres.Clientes.Commands.CreateCourseCommand;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CourseController : BaseApiController
    {
        //POST api/ <controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateCourseCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
