using Microsoft.EntityFrameworkCore;
using SmartQueue.Data;
using SmartQueue.Models;

namespace SmartQueue.Services;

public class TicketService
{
    private readonly AppDbContext _db;
    private readonly EventService _events;

    public TicketService(AppDbContext db, EventService events)
    {
        _db = db;
        _events = events;
    }

    public List<Ticket> GetAll() =>
        _db.Tickets.OrderBy(t => t.Id).ToList();

    public Ticket? GetById(int id) =>
        _db.Tickets.Find(id);

    public Ticket Add(string serviceName)
    {
        var count = _db.Tickets.Count();
        var ticket = new Ticket
        {
            Number = $"A-{101 + count}",
            ServiceName = serviceName,
            Status = "Ждёт",
            CreatedAt = DateTime.UtcNow
        };
        _db.Tickets.Add(ticket);
        _db.SaveChanges();
        _events.RecordTicketCreated(ticket);
        return ticket;
    }
}