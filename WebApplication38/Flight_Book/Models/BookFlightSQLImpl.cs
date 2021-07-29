using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_Book.Models
{
    public class BookFlightSQLImpl : IBookFlightRepository
    {
        private readonly BookFlightDbContext _context;

        public BookFlightSQLImpl(BookFlightDbContext context)
        {
            _context = context;
        }
     

        public List<BookFlightDetail> GetAllBookFlight()
        {
            return _context.BookFlightDetails.ToList();
        }

        public BookFlightDetail AddBookFlight(BookFlightDetail bookFlight)
        {
            _context.Add(bookFlight);
            _context.SaveChanges();
            return bookFlight;
        }
        public void DeleteBookFlight(int Id)
        {
            BookFlightDetail Book = GetBookFlightById(Id);
            _context.Remove(Book);
            _context.SaveChanges();
        }
        public BookFlightDetail GetBookFlightById(int id)
        {
            return _context.BookFlightDetails.FirstOrDefault(i => i.Id == id);
        }

        
    }
}
