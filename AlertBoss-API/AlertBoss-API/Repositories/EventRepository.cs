using AlertBoss_API.Databases;
using AlertBoss_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AlertBoss_API.Repositories;

public class EventRepository
{
     // Class Data
    public DbContext Context;
    public DbSet<EventModel> Events;

    // Class Constructor
    public EventRepository(MySQLDatabase context)
    {
        this.Context = context;
        this.Events = context.Events;
    }
    
    // Create Event
    public async Task<EventModel> Create(EventModel eventModel)
    {
        try
        {
            await this.Events.AddAsync(eventModel);
            await this.Context.SaveChangesAsync();
            return eventModel;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Event (using Id)
    public async Task<EventModel> Get(int id)
    {
        try
        {
            foreach (var U in Events)
            {
                if (id == U.Id)
                {
                    return U;
                }
            }

            throw new Exception("No events with matching ID were found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Events
    public async Task<IEnumerable<EventModel>> GetAll()
    {
        try
        {
            return await this.Events.ToArrayAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Update Event
    public async Task<EventModel> Update(EventModel eventModel)
    {
        try
        {
            foreach (var U in Events)
            {
                if (U.Id == eventModel.Id)
                {
                    // Manually add property updates here
                    // i.e -> U.Name = user.Name
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No events with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Delete Event
    public async Task<EventModel> Delete(int id)
    {
        try
        {
            foreach (var U in Events)
            {
                if (U.Id == id)
                {
                    Events.Remove(U);
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No events with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}