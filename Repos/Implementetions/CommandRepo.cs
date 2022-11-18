using Domain.Models;
using Repos.Interfaces;

namespace Repos.Implementetions
{
    public class CommandRepo : ICommandRepo
    {
        private List<Command> _commands;
        public CommandRepo()
        {
            _commands = new List<Command>();
        }
        public bool CreateCommand(Command command)
        {
            try
            {
                _commands.Add(command);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Command> GetAllCommands()
        {
            return _commands;
        }

        public Command GetCommand(Guid commandId)
        {
            var Command = _commands.FirstOrDefault(x=>x.CommandId == commandId);
            return Command;
        }

        public bool RemoveCommand(Guid commandId)
        {
            try
            {
                _commands.RemoveAll(x => x.CommandId == commandId);
            }
            catch (Exception)
            {
                return false;
            }
            return true;        
        }

        public Command UpdateCommand(Guid commandId, Command command)
        {
            Command Command = _commands.First(x=>x.CommandId == commandId);
            Command = command;
            return Command; 
        }
    }
}
