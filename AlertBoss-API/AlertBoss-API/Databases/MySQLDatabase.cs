using AlertBoss_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AlertBoss_API.Databases;

public class MySQLDatabase : DbContext
{
    // Class Constructor
    public MySQLDatabase(DbContextOptions options) : base(options){}
    
    // Alert Data
    public DbSet<Alert> Alerts { get; set; }
    // Alarm Data
    public DbSet<Alarm> Alarms { get; set; }
    // Contact Data
    public DbSet<Contact> Contacts { get; set; }
    // Device Data
    public DbSet<Device> Devices { get; set; }
    // Event Data
    public DbSet<EventModel> Events { get; set; }
    // Setting Data
    public DbSet<Settings> SettingsSet { get; set; }
    // User Data
    public DbSet<User> Users { get; set; }
}