using Flight_Book.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_Book.Controllers
{

    [ApiController]
    public class BookFlightController : ControllerBase
    {
        private IBookFlightRepository IBookFlightRepository = null;
        public BookFlightController(IBookFlightRepository bookFlightRepository)
        {
            this.IBookFlightRepository = bookFlightRepository;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            return Ok(IBookFlightRepository.GetAllBookFlight());
        }




        [HttpGet]
        [Route("api/[controller]/{id}")]


        public BookFlightDetail GetBookFlightById(int id)
        {
            return IBookFlightRepository.GetBookFlightById(id);
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult Post(BookFlightDetail bookFlight)
        {
            var data = IBookFlightRepository.AddBookFlight(bookFlight);
            return Created(HttpContext.Request.Scheme + "://" +
                HttpContext.Request.Host + "/" + HttpContext.Request.Path + "/" + bookFlight.Id, data);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]

        public string DeleteBookFlight(int id)
        {
            IBookFlightRepository.DeleteBookFlight(id);
            return "Deleted";



        }
    }
}
