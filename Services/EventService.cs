using SmartQueue.Data;
using SmartQueue.Models;

namespace SmartQueue.Services;

public class EventService
{
    private readonly AppDbContext _db;

    public EventService(AppDbContext db) => _db = db;

    public List<SystemEvent> GetAll() =>
        _db.SystemEvents.OrderByDescending(e => e.Id).ToList();

    public void RecordTicketCreated(Ticket ticket)
    {
        _db.SystemEvents.Add(new SystemEvent
        {
            EventType = "Создан талон",
            TicketId = ticket.Id,
            TicketNumber = ticket.Number,
            CreatedAt = DateTime.UtcNow,
            Status = "Новое"
        });
        _db.SaveChanges();
    }
}