namespace TaskHandler.Shared.Auth.Events;

public class UserSignedUpData
{
    public string UserId { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime SignedUpAt { get; set; }
    public string IpAddress { get; set; } = string.Empty;
}