using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CourseController : BaseApiController
    {
        //POST api/ <controller>
        private readonly ICourseServices _courseServices;

        public CourseController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Post(Course command)
        {
            return Ok(_courseServices.SaveCourse(command));
        }

        [HttpPost("Contract")]
        public async Task<IActionResult> Contract(ContractC command)
        {
            return Ok(_courseServices.SaveContractC(command));
        }

        [HttpPost("DressItem")]
        public async Task<IActionResult> DressItem(DressItem command)
        {
            return Ok(_courseServices.SaveDressItem(command));
        }

        [HttpGet("InfoContrato")]
        public async Task<IActionResult> InfoContrato(string codeCourse)
        {
            var result =  _courseServices.SearchCourse(codeCourse);
            if(result != null) { 
            return Ok(result);
            }
            else {
                return BadRequest();
            }

        }
    }
}
