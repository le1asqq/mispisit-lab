using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartQueue.Models;
using SmartQueue.Services;

namespace SmartQueue.Pages.Tickets;

public class DetailsModel : PageModel
{
    private readonly TicketService _service;
    public Ticket? Ticket { get; set; }

    public DetailsModel(TicketService service) => _service = service;

    public void OnGet(int id) => Ticket = _service.GetById(id);
}