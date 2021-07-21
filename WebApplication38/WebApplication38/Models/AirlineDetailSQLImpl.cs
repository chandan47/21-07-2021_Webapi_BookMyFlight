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
            return _context.AirlineDetails.FirstOrDefault( i=> i.Id == flightnumber);
        }

        public AirlineDetails AddAirline(AirlineDetails airline)
        {
            _context.Add(airline);
            _context.SaveChanges();
            return airline;
        }
    }
}
