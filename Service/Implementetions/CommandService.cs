using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Repos.Interfaces;
using Service.Interfaces;
using System.ComponentModel.Design;

namespace Service.Implementetions
{
    public class CommandService : ICommandService
    {
        private readonly ICommandRepo _commandRepo;
        public CommandService(ICommandRepo commandRepo)
        {
            _commandRepo = commandRepo;
        }
        public Task CreateCommand(CommandRequest command)
        {
            var _command = new Command
            {
                CommandId = Guid.NewGuid(),
                Name = command.Name,
                Description = command.Description,
                CommandCode = command.CommandCode
            };
            var result = _commandRepo.CreateCommand(_command);
            return Task.FromResult(result);
        }

        public List<Command> GetAllCommands()
        {
            return _commandRepo.GetAllCommands();
        }

        public Command GetCommand(Guid commandId)
        {
            return _commandRepo.GetCommand(commandId);
        }

        public string GetCommandForMC()
        {
            return _commandRepo.GetCommandForMC();
        }

        public Task RemoveCommand(Guid commandId)
        {
            var result = _commandRepo.RemoveCommand(commandId); 
            return Task.FromResult(result);
        }

        public Command UpdateCommand(Guid commandId, CommandRequest command)
        {
            if (_commandRepo.GetCommand(commandId)==null)
                return null;
            var _command = new Command
            {
                Name = command.Name,
                Description = command.Description,
                CommandCode = command.CommandCode
            };
            return _commandRepo.UpdateCommand(commandId, _command);
        }

        public bool Exist(string code)
        {
            if (_commandRepo.Exist(code))
                return true;
            return false;
        }
    }
}
