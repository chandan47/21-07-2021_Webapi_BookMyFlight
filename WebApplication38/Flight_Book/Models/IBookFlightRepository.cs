using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_Book.Models
{
    public interface IBookFlightRepository
    {
        List<BookFlightDetail> GetAllBookFlight();
        BookFlightDetail GetBookFlightById(int id);
        BookFlightDetail AddBookFlight(BookFlightDetail bookFlight);
        void DeleteBookFlight(int id);
    }
}
