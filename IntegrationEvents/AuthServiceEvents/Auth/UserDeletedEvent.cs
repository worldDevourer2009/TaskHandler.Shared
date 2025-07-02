namespace TaskHandler.Shared.IntegrationEvents.AuthServiceEvents.Auth;

public record UserDeletedEvent(string Username, string Email, DateTime DeletedAt);