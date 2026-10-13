using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartQueue.Models;
using SmartQueue.Services;

namespace SmartQueue.Pages.Queue;

public class IndexModel : PageModel
{
    private readonly TicketService _service;
    public List<Ticket> Tickets { get; set; } = new();

    public IndexModel(TicketService service) => _service = service;

    public void OnGet() => Tickets = _service.GetAll();
}