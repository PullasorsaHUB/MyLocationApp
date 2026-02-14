

namespace MyLocationApp.Backend.Models;

public class TodoItem
{
    public int id { get; set; }                 // Prisma key (uniikki id)
    public string Title { get; set; } = "";     // Tehtävän otsikko
    public bool IsDone { get; set; }            // Onko Session tehty
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;   // Luonti Aika
}