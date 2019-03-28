using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class Cinema
    {
        public Cinema()
        {
            Halls = new List<int>();
            ListOfMovies = new List<Movie>();

        }

        public Cinema(string name)
        {
            Name = name;
            Halls = new List<int>();
            ListOfMovies = new List<Movie>();

        }

        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }



        public void MoviePlaying(Movie film)
        {
            Console.WriteLine($"The movie {film.Title} is playing!");
        }
    }

    
}
