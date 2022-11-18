using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace Service.Implementetions
{
    internal class CommandService : ICommandService
    {
        public IActionResult CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public List<Command> GetAllCommands()
        {
            throw new NotImplementedException();
        }

        public Command GetCommand(Guid commandId)
        {
            throw new NotImplementedException();
        }

        public IActionResult RemoveCommand(Guid commandId)
        {
            throw new NotImplementedException();
        }

        public Command UpdateCommand(Guid commandId, Command command)
        {
            throw new NotImplementedException();
        }
    }
}
