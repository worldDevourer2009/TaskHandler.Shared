namespace TaskHandler.Shared.Auth.DTO.Auth;

public record LogoutDto(string Email, string? Token = null);