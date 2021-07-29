using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_Book.Models
{
    public class BookFlightDetail
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string emailID { get; set; }
        public int noOfSeatsToBook { get; set; }
        public string mealType { get; set; }
        public int seatNumber { get; set; }
        public string discountcode { get; set; }
        public string triptype { get; set; }
        public string fromPlace { get; set; }
        public string toPlace { get; set; }
        public string startdatetime {get; set;}
        public decimal totalPrice { get; set; }
        //public BookFlightStatus status { get; set; }
    }
    //public enum BookFlightStatus
    //{
    //    Booked = 0,
    //    Cancelled = 1
    //}
}
