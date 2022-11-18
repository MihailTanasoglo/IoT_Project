using Domain.Models;

namespace Repos.Interfaces
{
    public interface ICommandRepo
    {
        public List<Command> GetAllCommands();
        public Command GetCommand(Guid commandId);
        public bool RemoveCommand(Guid commandId);
        public Command UpdateCommand(Guid commandId, Command command);
        public bool CreateCommand(Command command);
    }
}
