namespace TaskHandler.Shared.Notifications.DTOs.Groups.Responses;

public class DeleteGroupResponseDto
{
    public bool Success { get; set; }
    public string? Message { get; set; } = null;
}