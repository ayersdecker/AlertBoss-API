using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("Users")]
public class User
{
    [Column("uid")]
    public required int Id { get; set; }
    [Column("username")]
    public required string Username { get; set; }
    [Column("email")]
    public required string Email { get; set; }
    [Column("deviceId")]
    public string? DeviceId { get; set; }
    [Column("location")]
    public string? Location { get; set; }
    [Column("phoneNo")]
    public string? Phone { get; set; }

}