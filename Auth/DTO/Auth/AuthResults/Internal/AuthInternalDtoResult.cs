namespace TaskHandler.Shared.Auth.DTO.Auth.AuthResults.Internal;

public record AuthInternalDtoResult(bool Success, string? Token = null, string? Message = null);