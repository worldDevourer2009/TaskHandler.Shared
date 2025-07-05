using System.Security.Claims;

namespace TaskHandler.Shared.Auth.DTO.Auth.AuthResults;

public record GenerateInternalTokenDto(string ServiceClientId, string ClientSecret, IEnumerable<Claim>? AdditionalClaims = null);