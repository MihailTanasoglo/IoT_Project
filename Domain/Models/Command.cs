namespace Domain.Models
{
    public class Command
    {
        public Guid CommandId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } 
        public string CommandCode { get; set; } 
    }
}