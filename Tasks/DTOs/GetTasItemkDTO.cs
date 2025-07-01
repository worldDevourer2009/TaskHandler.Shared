using TaskHandler.Shared.Tasks.Enums;
using TaskStatus = TaskHandler.Shared.Tasks.Enums.TaskStatus;

namespace TaskHandler.Shared.Tasks.DTOs;

public class GetTasItemkDTO
{
    public Guid? UserId { get; set; }
    public string? Title { get; set; } = "New Task";
    public string? Description { get; set; } = string.Empty;
    public TaskStatus? Status { get; set; } = TaskStatus.Pending;
    public TaskType? TaskType { get; set; } = Enums.TaskType.None;
    public TaskPriority? Priority { get; set; } = 0;
    public DateTime? CompletionDate { get; set; }
    
    public bool HasUserId => UserId != null;
}