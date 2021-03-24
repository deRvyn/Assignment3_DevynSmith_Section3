using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9_DevynSmith_Section3.Models
{
    //creates the database respository to populate the data and pass it into the index
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDbContext _context;

        //Constructor for the class
        public EFMovieRepository(MovieDbContext context)
        {
            _context = context;
        }
        public IQueryable<Movie> Movies => _context.Movies;
    }
}
