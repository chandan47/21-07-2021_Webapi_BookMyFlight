using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication38.Models
{
    public class AirlineDetails
    {
        public int Id { get; set; }
        public string airlineName { get; set; }
        public string uploadLogo { get; set; }
        public int flightNumber { get; set; }
        public string fromPlace { get; set; }
        public string toPlace { get; set; }
        public string startdatetime { get; set; }
        public string enddatetime { get; set; }
        public string scheduleddays { get; set; }
        public string instrumentUsed { get; set; }
        public int tNoBusinessClassSeats { get; set; }
        public int tNoNonBusinessClassSeats { get; set; }
        public decimal ticketCost { get; set; }
        public int numberofRows { get; set; }
        public string meal {get; set;}
        public bool isBlocked { get; set; }
        public int status { get; set; }
    }
}
