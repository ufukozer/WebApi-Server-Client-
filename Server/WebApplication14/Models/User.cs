using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Book Book { get; set; }
    }
}
