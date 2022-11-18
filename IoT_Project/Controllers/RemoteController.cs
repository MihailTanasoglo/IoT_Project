using Microsoft.AspNetCore.Mvc;

namespace IoT_Project.Controllers
{
    public class RemoteController: ControllerBase
    {
        private readonly int _baudRate = 9600;
        private readonly string _portName = "COM100";

        [HttpGet]
        public IActionResult GetCommand(string command)
        {

            return Ok(command);
        }
        [HttpPost]
        public IActionResult InsertCommand(string command)
        {
            return Ok(command);
        }

    }
}
