namespace TaskHandler.Shared.Notifications.DTOs.Notifications;

public record NotificationDto(string? Title, string? Body, string? Sender, string? Receiver, bool? IsRead, DateTime? CreatedAt);