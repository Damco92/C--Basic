using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class Movie
    {
        public string Title { get; set; }
        private int _rating;
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 6 && value > 0)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("The rating must be from 1 to 5");
                }
            }
        }
        public double TicketPrice { get; set; }
        public Genre Genre;

        public Movie(string title,Genre gen,int rate)
        {
            Title = title;
            Genre = gen;
            Rating = rate;
            TicketPrice = 5 * rate;
        }

        public void MoviePlaying(List<Movie> myMovies)
        {
            foreach (var movie in myMovies)
            {
                Console.WriteLine($"The movie {movie.Title} is playing");
            }
            
        }

    }
}
