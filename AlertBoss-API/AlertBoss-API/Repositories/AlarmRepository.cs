using AlertBoss_API.Databases;
using AlertBoss_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AlertBoss_API.Repositories;

public class AlarmRepository
{
    // Class Data
    public DbContext Context;
    public DbSet<Alarm> Alarms;

    // Class Constructor
    public AlarmRepository(MySQLDatabase context)
    {
        this.Context = context;
        this.Alarms = context.Alarms;
    }
    
    // Create Alarm
    public async Task<Alarm> Create(Alarm alarm)
    {
        try
        {
            await this.Alarms.AddAsync(alarm);
            await this.Context.SaveChangesAsync();
            return alarm;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Alarm (using Id)
    public async Task<Alarm> Get(int id)
    {
        try
        {
            foreach (var U in Alarms)
            {
                if (id == U.Id)
                {
                    return U;
                }
            }

            throw new Exception("No alarms with matching ID were found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Alarms
    public async Task<IEnumerable<Alarm>> GetAll()
    {
        try
        {
            return await this.Alarms.ToArrayAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Update Alarm
    public async Task<Alarm> Update(Alarm alarm)
    {
        try
        {
            foreach (var U in Alarms)
            {
                if (U.Id == alarm.Id)
                {
                    // Manually add property updates here
                    // i.e -> U.Name = user.Name
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No alarms with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Delete Alarm
    public async Task<Alarm> Delete(int id)
    {
        try
        {
            foreach (var U in Alarms)
            {
                if (U.Id == id)
                {
                    Alarms.Remove(U);
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No alarms with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}