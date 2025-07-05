namespace TaskHandler.Shared.Notifications.DTOs.Groups;

public class CreateNotificationGroupDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> Members { get; set; }
}