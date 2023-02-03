using Repository.Interface;
using Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkUnit.Interface;
using Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace WorkUnit.Implementation
{
    public class AbstractFactoryRepository : IAbstractFactoryRepository
    {
        private readonly DoubleDbContext _dbcontext;
        private readonly IDbConnection _con;
        public AbstractFactoryRepository(DoubleDbContext dbcontex, IDbConnection con)
        {
            _dbcontext = dbcontex;
            _con = con;
            Person = new PersonRepository(_dbcontext,_con);
            User = new UserRepository(_dbcontext);
        }
        public IPersonRepository Person { get; private set; }

        public IUserRepository User { get; private set; }
    }
}
