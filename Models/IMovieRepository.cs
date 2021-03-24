using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9_DevynSmith_Section3.Models
{
    //create the movies repo
    public class IMovieRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
