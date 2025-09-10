namespace KanbanApp.Server.Domain.Entities;

public class Board
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;

    public Guid OwnerId { get; set; }
    public User Owner { get; set; } = null!;

    public ICollection<Column> Columns { get; set; } = new List<Column>();
}