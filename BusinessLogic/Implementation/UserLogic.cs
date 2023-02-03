using BusinessLogic.Interface;
using Domain.DTO.Input;
using Repository.Models;
using WorkUnit.Interface;

namespace BusinessLogic.Implementation
{
    public class UserLogic : IUserLogic
    {

        private readonly IAbstractFactoryRepository _factoryRepository;

        public UserLogic(IAbstractFactoryRepository factoryRepository)
        {
            _factoryRepository = factoryRepository;
        }

        public async Task<bool> GetUserLogin(UseLoginReq model)
        {
            var res = await _factoryRepository.User.GetUserLogin(new User
            {
                UserName = model.UserName,
                Password = model.Password,
            });

            if (res.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
