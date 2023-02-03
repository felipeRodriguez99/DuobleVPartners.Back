using Microsoft.AspNetCore.Mvc;
using Domain.DTO.Output;
using BusinessLogic.Interface;
using Domain.DTO.Input;

namespace DuobleVPartners.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonLogic _personLogic;

        public PersonController(IPersonLogic personLogic)
        {
            _personLogic = personLogic;
        }

        [HttpPost()]
        [Route("CreatePerson")]
        public async Task<ActionResult> CreatePerson([FromBody] PersonDtoReq req)
        {
            return Ok(await _personLogic.CreatePerson(req));
        }

        [HttpGet()]
        [Route("GetPersons")]
        public async Task<ActionResult> GetPersons()
        {            
            return Ok(await _personLogic.GetPersons());
        }
    }
}
