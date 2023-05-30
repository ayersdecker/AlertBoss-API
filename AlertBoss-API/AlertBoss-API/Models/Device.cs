using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("device")]
public class Device
{
    [Column("id")]
    public int Id { get; set; }
}