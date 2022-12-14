﻿using Domain.Models;

namespace Repos.Interfaces
{
    public interface ICommandRepo
    {
        public List<Command> GetAllCommands();
        public Command GetCommand(Guid commandId);
        public Command GetCommandForMC();
        public bool RemoveCommand(Guid commandId);
        public Command UpdateCommand(Guid commandId, Command command);
        public Command CreateCommand(Command command);
    }
}
