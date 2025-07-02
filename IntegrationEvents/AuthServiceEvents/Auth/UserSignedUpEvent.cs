namespace TaskHandler.Shared.IntegrationEvents.AuthServiceEvents.Auth;

public record UserSignedUpEvent(string Username, string Email, DateTime CreatedAt);