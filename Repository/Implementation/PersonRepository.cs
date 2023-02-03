using Repository.Context;
using Repository.Interface;
using Repository.Models;
using Dapper;
using System.Data;

namespace Repository.Implementation
{
    public class PersonRepository : IPersonRepository
    {

        private readonly DoubleDbContext _dbcontext;
        private readonly IDbConnection _con;

        public PersonRepository(DoubleDbContext dbcontext, IDbConnection con)
        {
            _dbcontext = dbcontext;
            _con = con;
        }

        public async Task<bool> CreatePerson(Person model)
        {

            await _dbcontext.Persons.AddAsync(model);
            await _dbcontext.SaveChangesAsync();
            return true;

        }

        public async Task<IEnumerable<Person>> GetPersons()
        {
            var persons = await _con.QueryAsync<Person>("GetPersons", null, commandType: CommandType.StoredProcedure);

            return persons;
        }
    }
}
