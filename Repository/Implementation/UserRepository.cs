using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interface;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly DoubleDbContext _dbcontext;

        public UserRepository(DoubleDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<bool> CreateUser(User model)
        {
            await _dbcontext.Users.AddAsync(model);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<List<User>> GetUserLogin(User model)
        {
            return await _dbcontext.Users.Where(p => p.UserName == model.UserName && p.Password == model.Password).ToListAsync();
        }
    }
}
