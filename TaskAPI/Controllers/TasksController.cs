using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var task = new string[]
            {
                "Task 1","Task 2","Task 3"
            };
            return Ok(task);
        }

        [HttpPost]
        public IActionResult Newtask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingWentWrong = true;
            if (somethingWentWrong)
                return BadRequest();
            return Ok();
            //test
        }
    }
}
