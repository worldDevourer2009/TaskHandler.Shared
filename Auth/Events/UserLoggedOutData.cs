namespace TaskHandler.Shared.Auth.Events;

public class UserLoggedOutData
{
    public string UserId { get; set; } = string.Empty;
    public DateTime LogoutTime { get; set; }
}