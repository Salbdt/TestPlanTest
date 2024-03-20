using App.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class Controller
{
    private readonly IService _service;

    public Controller(IService service) => _service = service;

    [HttpGet("GetAllPeople")]
    public async Task<List<Person>> GetAllPeople()
    {
        return await _service.GetAllPeople();
    }

    [HttpGet("GetPersonByID")]
    public async Task<Person> GetPersonById(int id)
    {
        return await _service.GetPersonById(id);
    }

}
