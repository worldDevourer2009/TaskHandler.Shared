using TaskHandler.Shared.Tasks.Enums;
using TaskStatus = TaskHandler.Shared.Tasks.Enums.TaskStatus;

namespace TaskHandler.Shared.Tasks.DTOs.Tasks;

public class UpdateTaskDTO
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public TaskStatus Status { get; set; }
    public TaskType TaskType { get; set; }
    public TaskPriority Priority { get; set; }
    public DateTime? CompletionDate { get; set; }
}