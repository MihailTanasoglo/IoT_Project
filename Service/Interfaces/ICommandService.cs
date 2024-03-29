﻿using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Service.Interfaces
{
    internal interface ICommandService
    {
        public List<Command> GetAllCommands();
        public Command GetCommand(Guid commandId);
        public IActionResult RemoveCommand(Guid commandId);
        public Command UpdateCommand(Guid commandId, Command command);
        public IActionResult CreateCommand(Command command);
    }
}
