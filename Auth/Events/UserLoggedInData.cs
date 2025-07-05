namespace TaskHandler.Shared.Auth.Events;

public class UserLoggedInData
{
    public string UserId { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime LoginTime { get; set; }
    public string IpAddress { get; set; } = string.Empty;
}