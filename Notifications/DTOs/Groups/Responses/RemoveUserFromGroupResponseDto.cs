namespace TaskHandler.Shared.Notifications.DTOs.Groups.Responses;

public class RemoveUserFromGroupResponseDto
{
    public bool Success { get; set; }
    public string? Message { get; set; } = null;
}