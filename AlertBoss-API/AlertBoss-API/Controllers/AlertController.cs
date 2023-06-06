using AlertBoss_API.Models;
using AlertBoss_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlertBoss_API.Controllers;

[ApiController]
[Route("api/alert")]
public class AlertController : ControllerBase
{
    // Repository Assignment
    private readonly AlertRepository _repository;

    // Class Constructor
    public AlertController(AlertRepository repository)
    {
        _repository = repository;
    }
    
    // Create Alert
    [HttpPost]
    public async Task<ActionResult> Create(Alert alert)
    {
        return Ok(await this._repository.Create(alert));
    }

    // Get Single Alert
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        return Ok(await this._repository.Get(id));
    }
    
    // Get All Alerts
    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        return Ok(await this._repository.GetAll());
    }
    
    // Update Alert
    [HttpPut]
    public async Task<ActionResult> Update(Alert alert)
    {
        return Ok(await this._repository.Update(alert));
    }
    
    // Delete Alert
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        return Ok(await this._repository.Delete(id));
    }





}