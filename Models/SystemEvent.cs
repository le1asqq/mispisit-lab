namespace SmartQueue.Models;

public class SystemEvent
{
    public int Id { get; set; }
    public string EventType { get; set; } = "";
    public int? TicketId { get; set; }
    public string TicketNumber { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Status { get; set; } = "Новое";
}