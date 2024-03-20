using App.Services;
using App.Services.Implementations;
using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Test.API.Controllers
{
    public class Controlador
    {
        private readonly IService _service;
        private readonly IConfiguration _config;

        public Controlador()
        {
            _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            _service = new Service(new PersonRepository(_config));
        }

        [Fact]
        public async void GetAllPeople()
        {
            // Act
            List<Person> people = await _service.GetAllPeople();

            // Assert
            Assert.NotEmpty(people);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public async void GetPersonById(int id)
        {
            // Act
            Person person = await _service.GetPersonById(id);

            // Assert
            Assert.NotNull(person);
        }
    }
}