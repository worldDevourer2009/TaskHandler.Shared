namespace TaskHandler.Shared.Auth.DTO.Auth.AuthResults;

public record SignUpResultDto(bool Success, string? AccessToken = null, string? Message = null);