using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;
//
[Table("Alarms")]
public class Alarm
{
    [Column("alarmId")]
    public int Id { get; set; }
    [Column("eventType")]
    public string EventType { get; set; }
    [Column("time")]
    public DateTime Time { get; set; }
    [Column("snooze")]
    public bool Snooze { get; set; }
    [Column("active")]
    public bool Active { get; set; }
}