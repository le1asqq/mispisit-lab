using Microsoft.EntityFrameworkCore;
using SmartQueue.Models;

namespace SmartQueue.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Ticket> Tickets => Set<Ticket>();
}