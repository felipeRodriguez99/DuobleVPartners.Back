using Domain.DTO.Input;
using Domain.DTO.Output;
using Repository.Models;

namespace BusinessLogic.Interface
{
    public interface IPersonLogic
    {
        Task<PersonDtoRes> CreatePerson (PersonDtoReq model);
        Task<List<GetPersonsDtoRes>> GetPersons();
    }
}
