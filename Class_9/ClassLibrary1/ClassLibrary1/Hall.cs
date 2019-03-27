using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Hall
    {
        public Hall(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> moviesList { get; set; }

        public void NowPlaying(Movie film)
        {
            Console.WriteLine($"Now playing: {film.Title}");
        }
    }
}
