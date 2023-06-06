using AlertBoss_API.Models;
using AlertBoss_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlertBoss_API.Controllers;

[ApiController]
[Route("api/alarm")]
public class AlarmController : ControllerBase
{
    // Repository Assignment
    private readonly AlarmRepository _repository;

    // Class Constructor
    public AlarmController(AlarmRepository repository)
    {
        _repository = repository;
    }

    // Create Alarm
    [HttpPost]
    public async Task<ActionResult> Create(Alarm alarm)
    {
        return Ok(await this._repository.Create(alarm));
    }

    // Get Single Alarm
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        return Ok(await this._repository.Get(id));
    }

    // Get All Alarms
    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        return Ok(await this._repository.GetAll());
    }

    // Update Alarm
    [HttpPut]
    public async Task<ActionResult> Update(Alarm alarm)
    {
        return Ok(await this._repository.Update(alarm));
    }

    // Delete User
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        return Ok(await this._repository.Delete(id));
    }
}
