using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public async Task<List<Person>> GetAll()
        {
            List<Person> list = new();

            return list;
        }

        public async Task<Person> GetById(int id)
        {
            return null;
        }
    }
}