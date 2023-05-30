using AlertBoss_API.Databases;
using AlertBoss_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AlertBoss_API.Repositories;

public class ContactRepository
{
     // Class Data
    public DbContext Context;
    public DbSet<Contact> Contacts;

    // Class Constructor
    public ContactRepository(MySQLDatabase context)
    {
        this.Context = context;
        this.Contacts = context.Contacts;
    }
    
    // Create Contact
    public async Task<Contact> Create(Contact contact)
    {
        try
        {
            await this.Contacts.AddAsync(contact);
            await this.Context.SaveChangesAsync();
            return contact;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Contact (using Id)
    public async Task<Contact> Get(int id)
    {
        try
        {
            foreach (var U in Contacts)
            {
                if (id == U.Id)
                {
                    return U;
                }
            }

            throw new Exception("No contacts with matching ID were found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Get Contacts
    public async Task<IEnumerable<Contact>> GetAll()
    {
        try
        {
            return await this.Contacts.ToArrayAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Update Contact
    public async Task<Contact> Update(Contact contact)
    {
        try
        {
            foreach (var U in Contacts)
            {
                if (U.Id == contact.Id)
                {
                    // Manually add property updates here
                    // i.e -> U.Name = user.Name
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No contacts with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    // Delete Contact
    public async Task<Contact> Delete(int id)
    {
        try
        {
            foreach (var U in Contacts)
            {
                if (U.Id == id)
                {
                    Contacts.Remove(U);
                    await this.Context.SaveChangesAsync();
                    return U;
                }
            }

            throw new Exception("No contacts with matching Id found");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}