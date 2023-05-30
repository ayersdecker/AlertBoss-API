using AlertBoss_API.Models;
using AlertBoss_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlertBoss_API.Controllers;

[ApiController]
[Route("api/settings")]
public class SettingController : ControllerBase
{
    // Repository Assignment
    private readonly SettingRepository _repository;

    // Class Constructor
    public SettingController(SettingRepository repository)
    {
        _repository = repository;
    }
    
    // Create Settings
    [HttpPost]
    public async Task<ActionResult> Create(Settings settings)
    {
        return Ok(await this._repository.Create(settings));
    }

    // Get Single Settings
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        return Ok(await this._repository.Get(id));
    }
    
    // Get All Settings
    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        return Ok(await this._repository.GetAll());
    }
    
    // Update Settings
    [HttpPut]
    public async Task<ActionResult> Update(Settings settings)
    {
        return Ok(await this._repository.Update(settings));
    }
    
    // Delete Settings
    [HttpDelete]
    public async Task<ActionResult> Delete(int id)
    {
        return Ok(await this._repository.Delete(id));
    }





}