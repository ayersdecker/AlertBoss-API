using AlertBoss_API.Databases;
using AlertBoss_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AlertBoss_API.Repositories;

public class SettingRepository
{
     // Class Data
    public DbContext Context;
    public DbSet<Settings> SettingsSet;

    // Class Constructor
    public SettingRepository(MySQLDatabase context)
    {
        this.Context = context;
        this.SettingsSet = context.SettingsSet;
    }
    
    // Create Settings
    public async Task<Settings> Create(Settings settings)
    {
        try
        {
            await this.SettingsSet.AddAsync(settings);
            await this.Context.SaveChangesAsync();
            return settings;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Settings (using Id)
    public async Task<Settings> Get(int id)
    {
        try
        {
            foreach (var U in SettingsSet)
            {
                if (id == U.Id)
                {
                    return U;
                }
            }

            throw new Exception("No settings with matching ID were found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Settings
    public async Task<IEnumerable<Settings>> GetAll()
    {
        try
        {
            return await this.SettingsSet.ToArrayAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Update Settings
    public async Task<Settings> Update(Settings settings)
    {
        try
        {
            foreach (var U in SettingsSet)
            {
                if (U.Id == settings.Id)
                {
                    // Manually add property updates here
                    // i.e -> U.Name = user.Name
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No settings with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Delete Settings
    public async Task<Settings> Delete(int id)
    {
        try
        {
            foreach (var U in SettingsSet)
            {
                if (U.Id == id)
                {
                    SettingsSet.Remove(U);
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No settings with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}