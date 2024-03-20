using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAll();
        Task<Person> GetById(int id);
    }
}