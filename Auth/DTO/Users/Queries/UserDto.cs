using System.ComponentModel.DataAnnotations;

namespace TaskHandler.Shared.Auth.DTO.Users.Queries;

public class UserDto
{
    public Guid? Id { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Email { get; set; }
    public string? IpAddress { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? LastLogin { get; set; }
    public bool? IsActive { get; set; }
}