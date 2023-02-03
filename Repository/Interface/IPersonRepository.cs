using Domain.DTO.Output;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IPersonRepository
    {
        Task<bool> CreatePerson(Person model);
        Task<IEnumerable<Person>> GetPersons();
    }
}
