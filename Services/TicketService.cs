using SmartQueue.Models;

namespace SmartQueue.Services;

public class TicketService
{
    private readonly List<Ticket> _tickets = new();
    private int _nextId = 1;

    public TicketService()
    {
        // Демо данные
        Add("Оформление документов");
        Add("Получение справки");
        Add("Консультация специалиста");
    }

    public List<Ticket> GetAll() => _tickets;

    public Ticket? GetById(int id) => _tickets.FirstOrDefault(t => t.Id == id);

    public Ticket Add(string serviceName)
    {
        var ticket = new Ticket
        {
            Id = _nextId,
            Number = $"A-{100 + _nextId}",
            ServiceName = serviceName,
            Status = "Ждёт",
            CreatedAt = DateTime.Now
        };
        _tickets.Add(ticket);
        _nextId++;
        return ticket;
    }
}