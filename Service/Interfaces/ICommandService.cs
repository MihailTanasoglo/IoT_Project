using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Service.Interfaces
{
    public interface ICommandService
    {
        public List<Command> GetAllCommands();
        public Command GetCommand(Guid commandId);
        public string GetCommandForMC();
        public Task RemoveCommand(Guid commandId);
        public Command UpdateCommand(Guid commandId, CommandRequest command);
        public Task CreateCommand(CommandRequest command);
        public bool Exist(string code);
    }
}
