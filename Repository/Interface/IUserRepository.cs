using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IUserRepository
    {
        Task<bool> CreateUser (User model);
        Task<List<User>> GetUserLogin (User model);
    }
}
