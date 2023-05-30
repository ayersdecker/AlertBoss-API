using AlertBoss_API.Databases;
using AlertBoss_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AlertBoss_API.Repositories;

public class AlertRepository
{
    // Class Data
    public DbContext Context;
    public DbSet<Alert> Alerts;

    // Class Constructor
    public AlertRepository(MySQLDatabase context)
    {
        this.Context = context;
        this.Alerts = context.Alerts;
    }
    
    // Create Alert
    public async Task<Alert> Create(Alert alert)
    {
        try
        {
            await this.Alerts.AddAsync(alert);
            await this.Context.SaveChangesAsync();
            return alert;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Alert(using Id)
    public async Task<Alert> Get(int id)
    {
        try
        {
            foreach (var U in Alerts)
            {
                if (id == U.Id)
                {
                    return U;
                }
            }

            throw new Exception("No alerts with matching ID were found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Alerts
    public async Task<IEnumerable<Alert>> GetAll()
    {
        try
        {
            return await this.Alerts.ToArrayAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Update Alert
    public async Task<Alert> Update(Alert alert)
    {
        try
        {
            foreach (var U in Alerts)
            {
                if (U.Id == alert.Id)
                {
                    // Manually add property updates here
                    // i.e -> U.Name = user.Name
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No alerts with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Delete Alert
    public async Task<Alert> Delete(int id)
    {
        try
        {
            foreach (var U in Alerts)
            {
                if (U.Id == id)
                {
                    Alerts.Remove(U);
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No alerts with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}