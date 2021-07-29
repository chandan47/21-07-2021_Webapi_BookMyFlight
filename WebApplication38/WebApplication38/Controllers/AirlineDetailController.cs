using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication38.Models;
namespace WebApplication38.Controllers
{
    
    [ApiController]
    public class AirlineDetailController : ControllerBase
    {



            private IAirlineDetailRepository IAirLineDetailRepository = null;
            public AirlineDetailController(IAirlineDetailRepository airLineDetailRepository)
            {
                this.IAirLineDetailRepository = airLineDetailRepository;
            }
            [HttpGet]
            [Route("api/[controller]")]
            public List<AirlineDetails> Get()
            {
                return IAirLineDetailRepository.GetAllAirlines();
            }



            [HttpGet]
            [Route("api/[controller]/GetAirLinesById")]
            public IActionResult GetAirLinesById(int FlightNumber)
            {
                return Ok( IAirLineDetailRepository.GetAirlinesById(FlightNumber));
            }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post(AirlineDetails airline)
        {
            var data = IAirLineDetailRepository.AddAirline(airline);
            return Created(HttpContext.Request.Scheme + "://" +
                HttpContext.Request.Host + "/" + HttpContext.Request.Path + "/" + airline.Id, data);
        }

        // public AirlineDetails AddAirline(AirlineDetails airline)
        //     {
        //        airline.Id = ++count;
        //        airlines.Add(airline);
        //        return airline;
        //        }

        [HttpGet]
        [Route("api/[controller]/GetSearchFlight")]
        public IActionResult GetSearchFlight(int? flightNumber,string? fromPlace, string? toPlace)
        {
            return Ok(IAirLineDetailRepository.GetSearchFlight(flightNumber, fromPlace,toPlace));
        }

        [HttpPut]
        [Route("api/[controller]/BlockAirline/{flightNumber}/{isBlocked}")]

        public IActionResult BlockAirline(int flightNumber)
        {
            IAirLineDetailRepository.BlockAirline(flightNumber);
            return Ok();
        }

    }
    }





