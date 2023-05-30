using AlertBoss_API.Models;
using AlertBoss_API.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AlertBoss_API.Controllers;
[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    // Repository Assignment
    private readonly UserRepository _repository;

    // Class Constructor
    public UserController(UserRepository repository)
    {
        _repository = repository;
    }
    
    // Create User
    [HttpPost]
    public async Task<ActionResult> Create(User user)
    {
        return Ok(await this._repository.Create(user));
    }

    // Get Single User
    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        return Ok(await this._repository.Get(id));
    }
    
    // Get All Users
    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        return Ok(await this._repository.GetAll());
    }
    
    // Update User
    [HttpPut]
    public async Task<ActionResult> Update(User user)
    {
        return Ok(await this._repository.Update(user));
    }
    
    // Delete User
    [HttpDelete]
    public async Task<ActionResult> Delete(int id)
    {
        return Ok(await this._repository.Delete(id));
    }





}