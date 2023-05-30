using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models;

[Table("contact")]
public class Contact
{
    [Column("id")]
    public int Id { get; set; }
}