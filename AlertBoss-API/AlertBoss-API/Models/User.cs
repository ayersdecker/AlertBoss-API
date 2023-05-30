using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("user")]
public class User
{
    [Column("id")]
    public int Id { get; set; }
}