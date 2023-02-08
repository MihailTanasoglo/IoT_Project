using Domain.Models;

namespace Repos.Interfaces
{
    public interface ICommandRepo
    {
        public List<Command> GetAllCommands();
        public Command GetCommand(Guid commandId);
        public string GetCommandForMC();
        public bool RemoveCommand(Guid commandId);
        public Command UpdateCommand(Guid commandId, Command command);
        public Command CreateCommand(Command command);
        public bool Exist(string code);
    }
}
