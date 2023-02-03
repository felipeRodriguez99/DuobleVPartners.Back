using BusinessLogic.Interface;
using Domain.DTO.Input;
using Domain.DTO.Output;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkUnit.Interface;

namespace BusinessLogic.Implementation
{
    public class PersonLogic : IPersonLogic
    {

        private readonly IAbstractFactoryRepository _factoryRepository;

        public PersonLogic(IAbstractFactoryRepository factoryRepository)
        {
            _factoryRepository = factoryRepository;
        }
        public async Task<PersonDtoRes> CreatePerson(PersonDtoReq model)
        {
            var resultPerson = await _factoryRepository.Person.CreatePerson(new Person
            {
                Names = model.Names,
                LastName = model.LastName,
                DateCreated = DateTime.Now,
                FullName = String.Concat(model.Names," ", model.LastName),
                FullIdentification = String.Concat(model.TypeIdentification, " ", model.IdentificationNumber),
                Email = model.Email,
                IdentificationNumber = model.IdentificationNumber,
                TypeIdentification = model.TypeIdentification,

            });
            var resultUser = await _factoryRepository.User.CreateUser(new User
            {
                DateCreated = DateTime.Now,
                Password = model.Password,
                UserName = model.UserName
            });

            PersonDtoRes result = new PersonDtoRes();

            result.PersonIsSusses = resultPerson;
            result.UserIsSusses = resultUser;

            return result;
        }

        public async Task<List<GetPersonsDtoRes>> GetPersons()
        {
            var res = await _factoryRepository.Person.GetPersons();

            return res.Select(p => new GetPersonsDtoRes
            {
                DateCreated = p.DateCreated,
                Email= p.Email,
                FullIdentification = p.FullIdentification,
                FullName = p.FullName, 
                IdentificationNumber = p.IdentificationNumber, 
                LastName= p.LastName, 
                Names= p.Names,  
                TypeIdentification= p.TypeIdentification,
            }).ToList();
        }
    }
}
