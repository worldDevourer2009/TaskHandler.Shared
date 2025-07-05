namespace TaskHandler.Shared.Notifications.DTOs.Groups;

public class RemoveUserFromGroupDto
{
    public string GroupId { get; set; }
    public string UserId { get; set; }
}