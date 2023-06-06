using AlertBoss_API.Models;
using AlertBoss_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlertBoss_API.Controllers;

[ApiController]
[Route("api/device")]
public class DeviceController : ControllerBase
{
    // Repository Assignment
    private readonly DeviceRepository _repository;

    // Class Constructor
    public DeviceController(DeviceRepository repository)
    {
        _repository = repository;
    }
    
    // Create Device
    [HttpPost]
    public async Task<ActionResult> Create(Device device)
    {
        return Ok(await this._repository.Create(device));
    }

    // Get Single Device
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        return Ok(await this._repository.Get(id));
    }
    
    // Get All Devices
    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        return Ok(await this._repository.GetAll());
    }
    
    // Update Device
    [HttpPut]
    public async Task<ActionResult> Update(Device device)
    {
        return Ok(await this._repository.Update(device));
    }
    
    // Delete Device
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        return Ok(await this._repository.Delete(id));
    }





}