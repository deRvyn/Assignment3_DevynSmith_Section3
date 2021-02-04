using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3_DevynSmith_Section3.Models
{
    public static class TempStorage
    {
        private static List<AddMoviesResponse> movies = new List<AddMoviesResponse>();

        public static IEnumerable<AddMoviesResponse> Movies => movies;

        public static void AddMovie(AddMoviesResponse movie)
        {
            movies.Add(movie);
        }
    }
}
