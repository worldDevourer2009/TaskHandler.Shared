namespace TaskHandler.Shared.IntegrationEvents.AuthServiceEvents.Users;

public record UserCreatedEvent(string Username, string Email);