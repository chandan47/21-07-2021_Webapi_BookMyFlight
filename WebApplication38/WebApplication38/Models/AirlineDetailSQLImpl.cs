using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication38.Models
{
    public class AirlineDetailSQLImpl : IAirlineDetailRepository
    {
        private readonly EmployeeDbContext _context;
        public AirlineDetailSQLImpl(EmployeeDbContext context)
        {
            _context = context;
        }
        public List<AirlineDetails> GetAllAirlines()
        {
            return _context.AirlineDetails.ToList();
        }

        public AirlineDetails GetAirlinesById(int flightnumber)
        {
            return _context.AirlineDetails.FirstOrDefault( i=> i.flightNumber == flightnumber);
        }

        public AirlineDetails AddAirline(AirlineDetails airline)
        {
            _context.Add(airline);
            _context.SaveChanges();
            return airline;
        }
        public List<AirlineDetails> GetSearchFlight(int? flightnumber, string? fromPlace,string? toPlace)
        {
            if (flightnumber.HasValue && flightnumber.Value>=0)
            {
                return _context.AirlineDetails.Where(i=>i.flightNumber == flightnumber && i.isBlocked == false).ToList();

            }
            else
            {
                 return _context.AirlineDetails.Where(i => i.fromPlace.ToLower() == fromPlace.ToLower() &&  i.toPlace.ToLower() == toPlace.ToLower() && i.isBlocked == false).ToList();
            }
        }
        public void BlockAirline(int flightnumber)
        {
            var airLineDetail = _context.AirlineDetails.FirstOrDefault(i => i.flightNumber == flightnumber);
            if (airLineDetail != null)
            {
                airLineDetail.isBlocked = !airLineDetail.isBlocked;
                _context.Update(airLineDetail);
                _context.SaveChanges();
            }
        }
    }
}
