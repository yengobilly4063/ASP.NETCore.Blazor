using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class Repository : IRepository
    {

        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
            new Movie(){Title="The Avengers", ReleaseDate=new DateTime(2020, 1, 23)},
            new Movie(){Title="Apider-Man: Home Coming", ReleaseDate=new DateTime(2009, 5, 15)},
            new Movie(){Title="Moana", ReleaseDate=new DateTime(2010, 10, 21)},
            };
        }
    }
}
