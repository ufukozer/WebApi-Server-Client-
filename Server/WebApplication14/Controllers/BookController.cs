using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            List<Book> books = _bookRepository.GetAll();
            return new ActionResult<List<Book>>(books);
        }

    }
}
