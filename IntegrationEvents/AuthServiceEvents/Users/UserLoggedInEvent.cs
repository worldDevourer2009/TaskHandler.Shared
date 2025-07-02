namespace TaskHandler.Shared.IntegrationEvents.AuthServiceEvents.Users;

public record UserLoggedInEvent(string Username, string Email);