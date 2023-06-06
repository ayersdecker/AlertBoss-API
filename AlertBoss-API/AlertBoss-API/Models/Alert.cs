using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("Alerts")]
public class Alert
{
    [Column("alertId")]
    public int Id { get; set; }
    [Column("eventType")]
    public string EventType{ get; set; }
    [Column("alrtName")]
    public string Name { get; set; }
    [Column("location")]
    public string Location { get; set; }
    [Column("severity")]
    public string Severity { get; set; }
}