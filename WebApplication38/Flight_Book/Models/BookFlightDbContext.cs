using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_Book.Models
{
    public class BookFlightDbContext: DbContext
    {
        public BookFlightDbContext(DbContextOptions<BookFlightDbContext> options) : base(options)
        {

        }
        public DbSet<BookFlightDetail> BookFlightDetails { get; set; }
    }
}
