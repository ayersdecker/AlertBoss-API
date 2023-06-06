using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("Events")]
public class EventModel
{
    [Column("eventId")]
    public int Id { get; set; }
    [Column("eventType")]
    public string EventType { get; set; }
    [Column("color")]
    public string Color { get; set; }
    [Column("blink")]
    public int Blink { get; set; }
    [Column("output_email")]
    public bool OutputEmail { get; set; }
    [Column("output_text")]
    public bool OutputText { get; set; }
    [Column("deviceId")]
    public string DeviceId { get; set; }
}