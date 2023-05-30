using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("event")]
public class EventModel
{
    [Column("id")]
    public int Id { get; set; }
}