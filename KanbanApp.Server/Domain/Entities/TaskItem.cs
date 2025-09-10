namespace KanbanApp.Server.Domain.Entities;

public class TaskItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Enums.TaskStatus Status { get; set; } = Enums.TaskStatus.Todo;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Guid ColumnId { get; set; }
    public Column Column { get; set; } = null!;
}

