using System.ComponentModel.DataAnnotations.Schema;

namespace AlertBoss_API.Models
{
    [Table("Session")]
    public class Session
    {
        [Column("uid")]
        public int UID { get; set; }
        [Column("session_key")]
        public int Key { get; set; }
    }
}
