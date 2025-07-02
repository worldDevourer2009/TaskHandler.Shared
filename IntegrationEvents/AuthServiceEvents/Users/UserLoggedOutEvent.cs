namespace TaskHandler.Shared.IntegrationEvents.AuthServiceEvents.Users;

public record UserLoggedOutEvent(string Username, string Email);