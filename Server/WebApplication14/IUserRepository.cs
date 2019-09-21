using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Models;

namespace WebApplication14
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
