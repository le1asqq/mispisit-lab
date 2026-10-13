using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartQueue.Models;
using SmartQueue.Services;

namespace SmartQueue.Pages.Tickets;

public class NewModel : PageModel
{
    private readonly TicketService _service;
    public Ticket? CreatedTicket { get; set; }

    public NewModel(TicketService service) => _service = service;

    public void OnGet() { }

    public IActionResult OnPost(string serviceName)
    {
        if (string.IsNullOrWhiteSpace(serviceName))
        {
            return RedirectToPage("/AccessDenied");
        }
        CreatedTicket = _service.Add(serviceName);
        return Page();
    }
}