using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication38.Models
{
    public interface IAirlineDetailRepository
    {
        List<AirlineDetails> GetAllAirlines();
        AirlineDetails GetAirlinesById(int flightnumber);
        AirlineDetails AddAirline(AirlineDetails airline);

        List<AirlineDetails> GetSearchFlight(int? flightnumber,string? fromPlace, string? toPlace);
        void BlockAirline(int flightnumber);
    }
}
