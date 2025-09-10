namespace KanbanApp.Server.Domain.Entities;

public class Column
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public int Order { get; set; }

    public Guid BoardId { get; set; }
    public Board Board { get; set; } = null!;

    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
}