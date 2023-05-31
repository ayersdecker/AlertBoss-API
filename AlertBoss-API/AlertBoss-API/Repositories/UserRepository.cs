using AlertBoss_API.Databases;
using AlertBoss_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace AlertBoss_API.Repositories;

public class UserRepository
{
    // CLass Data
    public DbContext Context;
    public DbSet<User> Users;

    // Class Constructor
    public UserRepository(MySQLDatabase context)
    {
        this.Context = context;
        this.Users = context.Users;
    }
    
    // Create User
    public async Task<User> Create(User user)
    {
        try
        {
            await this.Users.AddAsync(user);
            await this.Context.SaveChangesAsync();
            return user;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get User (using Id)
    public async Task<User> Get(int id)
    {
        try
        {
            foreach (var U in Users)
            {
                if (id == U.Id)
                {
                    return U;
                }
            }

            throw new Exception("No Users with matching ID were found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Users
    public async Task<IEnumerable<User>> GetAll()
    {
        try
        {
            return await this.Users.ToArrayAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Update User
    public async Task<User> Update(User user)
    {
        try
        {
            foreach (var U in Users)
            {
                if (U.Id == user.Id)
                {
                    // Manually add property updates here
                    // i.e -> U.Name = user.Name
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No users with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Delete User
    public async Task<User> Delete(int id)
    {
        try
        {
            foreach (var U in Users)
            {
                if (U.Id == id)
                {
                    Users.Remove(U);
                    await this.Context.SaveChangesAsync();
                    await this.Context.DisposeAsync();
                    return U;
                }
            }

            throw new Exception("No users with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}