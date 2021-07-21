using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication38.Models;
namespace WebApplication38.Controllers
{
    [Route("api/[controller]")]
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
            [Route("api/[controller]/{id}")]
            public AirlineDetails GetAirLinesById(int id)
            {
                return IAirLineDetailRepository.GetAirlinesById(id);
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
    }
    }





