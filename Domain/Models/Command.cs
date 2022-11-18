using Domain.Constants;

namespace Domain.Models
{
    public class Command
    {
        public Guid CommandId { get; set; }
        public string Name { get; set; } = ConstantStrings.NewCommand;
        public string? Description { get; set; } 
        public int CommandCode { get; set; } 
    }
}