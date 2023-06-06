using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("Device")]
public class Device
{
    [Column("deviceId")]
    public int Id { get; set; }
    [Column("deviceName")]
    public string Name { get; set; }
    [Column("active")]
    public bool Active { get; set; }
    [Column("description")]
    public string Description { get; set; }
}