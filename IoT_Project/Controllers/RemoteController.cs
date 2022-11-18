using Microsoft.AspNetCore.Mvc;

namespace IoT_Project.Controllers
{
    public class RemoteController: ControllerBase
    {
        [HttpGet]
        public IActionResult GetCommand(string command)
        {
            return Ok(command);
        }
        [HttpPost]
        public IActionResult CreateCommand(string command)
        {
            return Ok(command);
        }
        [HttpPut]
        public IActionResult UpdateCommand(string command)
        {
            return Ok(command);
        }
        [HttpDelete]
        public IActionResult RemoveCommand(string command)
        {
            return Ok(command);
        }
    }
}
