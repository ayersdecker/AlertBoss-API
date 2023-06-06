using AlertBoss_API.Models;
using AlertBoss_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlertBoss_API.Controllers;

[ApiController]
[Route("api/event")]
public class EventController : ControllerBase
{
    // Repository Assignment
    private readonly EventRepository _repository;

    // Class Constructor
    public EventController(EventRepository repository)
    {
        _repository = repository;
    }
    
    // Create Event
    [HttpPost]
    public async Task<ActionResult> Create(EventModel eventModel)
    {
        return Ok(await this._repository.Create(eventModel));
    }

    // Get Single Event
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        return Ok(await this._repository.Get(id));
    }
    
    // Get All Events
    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        return Ok(await this._repository.GetAll());
    }
    
    // Update Event
    [HttpPut]
    public async Task<ActionResult> Update(EventModel eventModel)
    {
        return Ok(await this._repository.Update(eventModel));
    }
    
    // Delete Event
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        return Ok(await this._repository.Delete(id));
    }





}