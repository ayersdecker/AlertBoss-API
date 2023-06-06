using AlertBoss_API.Models;
using AlertBoss_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlertBoss_API.Controllers;

[ApiController]
[Route("api/contact")]
public class ContactController : ControllerBase
{
    // Repository Assignment
    private readonly ContactRepository _repository;

    // Class Constructor
    public ContactController(ContactRepository repository)
    {
        _repository = repository;
    }
    
    // Create Contact
    [HttpPost]
    public async Task<ActionResult> Create(Contact contact)
    {
        return Ok(await this._repository.Create(contact));
    }

    // Get Single Contact
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        return Ok(await this._repository.Get(id));
    }
    
    // Get All Contacts
    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        return Ok(await this._repository.GetAll());
    }
    
    // Update Contact
    [HttpPut]
    public async Task<ActionResult> Update(Contact contact)
    {
        return Ok(await this._repository.Update(contact));
    }
    
    // Delete Contact
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        return Ok(await this._repository.Delete(id));
    }





}