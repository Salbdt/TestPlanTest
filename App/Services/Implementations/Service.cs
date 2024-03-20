using Domain.Entities;
using Domain.Repositories;

namespace App.Services.Implementations;

public class Service : IService
{
    private readonly IPersonRepository _personRepository;

    public Service(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<List<Person>> GetAllPeople()
    {
        return await _personRepository.GetAll();
    }

    public async Task<Person> GetPersonById(int id)
    {
        return await _personRepository.GetById(id);
    }
}