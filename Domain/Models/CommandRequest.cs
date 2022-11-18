using Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class CommandRequest
    {
        public string Name { get; set; } = ConstantStrings.NewCommand;
        public string? Description { get; set; }
        [Required]
        public int CommandCode { get; set; }
    }
}
