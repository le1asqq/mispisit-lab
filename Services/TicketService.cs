using Microsoft.EntityFrameworkCore;
using SmartQueue.Data;
using SmartQueue.Models;

namespace SmartQueue.Services;

public class TicketService
{
    private readonly AppDbContext _db;

    public TicketService(AppDbContext db)
    {
        _db = db;
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
            CreatedAt = DateTime.Now
        };
        _db.Tickets.Add(ticket);
        _db.SaveChanges();
        return ticket;
    }
}