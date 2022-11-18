using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace IoT_Project.Controllers
{
    public class RemoteController: ControllerBase
    {
        private readonly ICommandService _commandService;
        public RemoteController(ICommandService commandService)
        {
            _commandService = commandService;
        }
        [HttpGet]
        public IActionResult GetCommand(Guid commandId)
        {
            var result = _commandService.GetCommand(commandId);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateCommand(CommandRequest command)
        {
            var result = _commandService.CreateCommand(command);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult UpdateCommand(Guid commandId, CommandRequest command)
        {
            var result = _commandService.UpdateCommand(commandId, command);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult RemoveCommand(Guid commandId)
        {
            var result = _commandService.RemoveCommand(commandId);
            return Ok(result);
        }
    }
}
