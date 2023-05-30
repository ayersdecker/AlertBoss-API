using AlertBoss_API.Databases;
using AlertBoss_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AlertBoss_API.Repositories;

public class DeviceRepository
{
    // Class Data
    public DbContext Context;
    public DbSet<Device> Devices;

    // Class Constructor
    public DeviceRepository(MySQLDatabase context)
    {
        this.Context = context;
        this.Devices = context.Devices;
    }
    
    // Create Device
    public async Task<Device> Create(Device device)
    {
        try
        {
            await this.Devices.AddAsync(device);
            await this.Context.SaveChangesAsync();
            return device;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Device (using Id)
    public async Task<Device> Get(int id)
    {
        try
        {
            foreach (var U in Devices)
            {
                if (id == U.Id)
                {
                    return U;
                }
            }

            throw new Exception("No devices with matching ID were found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Devices
    public async Task<IEnumerable<Device>> GetAll()
    {
        try
        {
            return await this.Devices.ToArrayAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Update Device
    public async Task<Device> Update(Device device)
    {
        try
        {
            foreach (var U in Devices)
            {
                if (U.Id == device.Id)
                {
                    // Manually add property updates here
                    // i.e -> U.Name = user.Name
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No devices with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Delete Device
    public async Task<Device> Delete(int id)
    {
        try
        {
            foreach (var U in Devices)
            {
                if (U.Id == id)
                {
                    Devices.Remove(U);
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No devices with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}