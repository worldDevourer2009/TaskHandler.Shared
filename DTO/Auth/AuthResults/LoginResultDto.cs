namespace TaskHandler.Shared.DTO.Auth.AuthResults;

public record LoginResultDto(bool Success, string? RefreshToken, string? AccessToken, string? Message);