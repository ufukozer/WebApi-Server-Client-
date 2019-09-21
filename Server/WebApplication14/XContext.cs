using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Models;

namespace WebApplication14
{
    public class XContext : DbContext
    {
        public XContext(DbContextOptions<XContext> options) : base(options)
        {
        }
        DbSet<User> Users { get; set; }
        DbSet<Book> Books { get; set; }
    }
}
