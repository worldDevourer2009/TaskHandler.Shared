namespace TaskHandler.Shared.IntegrationEvents.AuthServiceEvents.Auth;

public record UserLoggedInEvent(string Username, string Email);