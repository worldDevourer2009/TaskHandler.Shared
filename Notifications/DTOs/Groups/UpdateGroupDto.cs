namespace TaskHandler.Shared.Notifications.DTOs.Groups;

public class UpdateGroupDto
{
    public string? GroupId { get; set; }
    public string? Creator { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}