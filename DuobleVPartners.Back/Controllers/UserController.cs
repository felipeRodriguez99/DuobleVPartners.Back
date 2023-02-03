using BusinessLogic.Interface;
using Domain.DTO.Input;
using Microsoft.AspNetCore.Mvc;

namespace DuobleVPartners.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserLogic _userLogic;

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }


        [HttpGet()]
        [Route("GetUserLogin")]
        public async Task<ActionResult> GetUserLogin([FromRoute] UseLoginReq req)
        {
            return Ok(await _userLogic.GetUserLogin(req));
        }
    }
}
