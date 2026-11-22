using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartQueue.Services;

namespace SmartQueue.Pages.Events;

public class IndexModel : PageModel
{
    private readonly EventService _events;
    public List<SmartQueue.Models.SystemEvent> Items { get; set; } = [];

    public IndexModel(EventService events) => _events = events;

    public void OnGet() => Items = _events.GetAll();
}