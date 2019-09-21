using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Models;

namespace WebApplication14
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly XContext _xContext;
        public UserRepository(XContext xContext) : base(xContext)
        {
            _xContext = xContext;
        }
    }
}
