namespace SmartQueue.Models;

public class Ticket
{
    public int Id { get; set; }
    public string Number { get; set; } = "";
    public string ServiceName { get; set; } = "";
    public string Status { get; set; } = "Ждёт";
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}