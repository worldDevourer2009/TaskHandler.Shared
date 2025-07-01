namespace TaskHandler.Shared.DTO.Auth;

public record LogoutDto(string Email, string? Token = null);