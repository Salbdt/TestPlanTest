using Dapper;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Support.Helpers;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace Infrastructure.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly IConfiguration _config;

    public PersonRepository(IConfiguration config) => _config = config;

    public async Task<List<Person>> GetAll()
    {
        List<Person> list;

        using (var connection = new OracleConnection(_config.GetConnectionString(Common.ConnectionStringPrueba)))
        {
            var query = $@" SELECT
                                    ID, FIRST_NAME AS FirstName, LAST_NAME AS LastName,
                                    DOCUMENT_TYPE AS DocumentType, DOCUMENT_NUMBER AS DocumentNumber,
                                    BIRTH_DATE as BirthDate
                                FROM PERSONS";

            list = (await connection.QueryAsync<Person>(query)).ToList();
        }

        return list ?? new List<Person>();
    }

    public async Task<Person> GetById(int id)
    {
        Person item;

        using (var connection = new OracleConnection(_config.GetConnectionString(Common.ConnectionStringPrueba)))
        {
            var query = $@" SELECT
                                    ID, FIRST_NAME AS FirstName, LAST_NAME AS LastName,
                                    DOCUMENT_TYPE AS DocumentType, DOCUMENT_NUMBER AS DocumentNumber,
                                    BIRTH_DATE as BirthDate
                                FROM PERSONS
                                WHERE ID = :P_ID";

            item = await connection.QueryFirstAsync<Person>(query, new { P_ID = id });
        }

        return item;
    }
}