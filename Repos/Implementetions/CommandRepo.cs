using Domain.Models;
using Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Implementetions
{
    internal class CommandRepo : ICommandRepo
    {
        public bool CreateCommand(Command command)
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

        public bool RemoveCommand(Guid commandId)
        {
            throw new NotImplementedException();
        }

        public Command UpdateCommand(Guid commandId, Command command)
        {
            throw new NotImplementedException();
        }
    }
}
