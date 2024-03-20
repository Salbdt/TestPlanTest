using Domain.Entities;

namespace App.Services;

public interface IService
{
    Task<List<Person>> GetAllPeople();
    Task<Person> GetPersonById(int id);
}