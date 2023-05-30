using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("settings")]
public class Settings
{
    [Column("id")]
    public int Id { get; set; }
}