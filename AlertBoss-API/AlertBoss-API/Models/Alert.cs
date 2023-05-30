using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("alert")]
public class Alert
{
    [Column("id")]
    public int Id { get; set; }
}