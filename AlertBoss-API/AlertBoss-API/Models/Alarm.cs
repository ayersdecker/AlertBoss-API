using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("alarm")]
public class Alarm
{
    [Column("id")]
    public int Id { get; set; }
}