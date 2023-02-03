using Domain.DTO.Input;
using Domain.DTO.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IUserLogic
    {
        Task<bool> GetUserLogin(UseLoginReq model);
    }
}
