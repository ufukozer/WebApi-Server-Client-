using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Models;

namespace WebApplication14
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly XContext _xContext;

        public Repository(XContext xContext)
        {
            _xContext = xContext;
        }

        public List<T> GetAll()
        {
            return _xContext.Set<T>().ToList();
        }
    }
}
