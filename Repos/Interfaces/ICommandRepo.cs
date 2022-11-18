using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Interfaces
{
    internal interface ICommandRepo
    {
        public List<Command> GetAllCommands();
        public Command GetCommand(Guid commandId);
        public bool RemoveCommand(Guid commandId);
        public Command UpdateCommand(Guid commandId, Command command);
        public bool CreateCommand(Command command);
    }
}
