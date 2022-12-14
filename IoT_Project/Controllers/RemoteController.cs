using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace IoT_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RemoteController: ControllerBase
    {
        private readonly ICommandService _commandService;
        public RemoteController(ICommandService commandService)
        {
            _commandService = commandService;
        }

        [HttpGet("getById")]
        public IActionResult GetById(Guid commandId)
        {
            var result = _commandService.GetCommand(commandId);
            return Ok(result);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _commandService.GetAllCommands();
            return Ok(result);
        }

        [HttpGet("getCommand")]
        public IActionResult GetForMC()
        {
            var result = _commandService.GetCommandForMC();
            return Ok(result);
        }

        [HttpPost("Insert")]
        public IActionResult Create(CommandRequest command)
        {
            var result = _commandService.CreateCommand(command);
            return Ok(result);
        }

        [HttpPut("Update")]
        public IActionResult Update(Guid commandId, CommandRequest command)
        {
            var result = _commandService.UpdateCommand(commandId, command);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public IActionResult Remove(Guid commandId)
        {
            var result = _commandService.RemoveCommand(commandId);
            return Ok(result);
        }
    }
}
